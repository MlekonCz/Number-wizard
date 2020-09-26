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

        

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Welcome Little Wiizard");
        Debug.Log("You have to pick one nuumber!");
        Debug.Log("Highest number is: " + max);
        Debug.Log("While the lowest is: " + min);
        Debug.Log("Get ready!!");
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push down = lower, push Enter = Correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed");
            min = guess;
            Debug.Log(guess);
        }
       else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
            max = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {    
           Debug.Log("Enter key was pressed");
        }
    }
}
