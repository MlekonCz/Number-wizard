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
        Debug.Log("Welcome to Number Wizard, you little friek");
        Debug.Log("You have to pick one number!");
        Debug.Log("Highest number is: " + max);
        Debug.Log("While the lowest is: " + min);
        Debug.Log("Get ready!!");
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = if your number is higher, Push down = if it is lower, and push Enter = if it is Correct");

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
           Debug.Log("Iam a genius!!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess + "?");
    }
}
