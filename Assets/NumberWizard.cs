using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {


        StartGame();


    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("¡Bienvenido a Number Wizard!");
        Debug.Log("Piensa en un numero, no lo digas , tampoco lo escribas...");
        Debug.Log("El numero mas alto que puedes elegir es: " + max);
        Debug.Log("El numero mas bajo que puedes elegir es: " + min);
        Debug.Log("Dime si el numero en que pensaste es mas alto o mas bajo que: " + guess);
        Debug.Log("Flecha Arriba para = Mas alto, Flecha Abajo para = Mas bajo, Presiona Enter = Correcto");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();



        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
           
            Debug.Log("Logre adivinar en que pensabas");
            StartGame();
        }
    }
    void NextGuess()
    {   
          guess = (max + min) / 2;
          Debug.Log("Dime si el numero en que pensaste es mas alto o mas bajo que: " + guess);
        
    }
}
