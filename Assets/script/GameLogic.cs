//using System.Collections;
//using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameLogic : MonoBehaviour
{
    public InputField UserInput;
    private int randomNumber;
    public Text hint;
    public Button submitButton;
    public int minvalue;
    public int maxvalue;
    // Start is called before the first frame update
    void Start()
    {
        resetGame();
    }

    // Update is called once per frame
    void Update(){}

    public void resetGame(){
        minvalue = 0;
        maxvalue = 101;
        randomNumber = getRandomNumber(minvalue,maxvalue);
        hint.text = "Try guessing the number between " + minvalue + " and " + (maxvalue-1);
    }
    public void OnButtonClick(){
        Debug.Log("Clicked");  
        Debug.Log("The userInput is: " + UserInput.text);
        int userInput = 0;
        
        try{
            userInput = int.Parse(UserInput.text);
        }
        catch (FormatException e){
            Console.WriteLine(e.Message);
            hint.text = "Please input correctly~ I know you test my patient!";
        }

        if (userInput == randomNumber){
            Debug.Log("You win!");
            hint.text = "You win!";
            //submitButton.interactable = false;
        }
        else{
            if (userInput > randomNumber){
                Debug.Log("Too high!");
                hint.text = "Try lower";
            }
            else{
                Debug.Log("Too low!");
                hint.text = "Try higher";
            }
        }
    }

    private int getRandomNumber(int min, int max){
        //Random ran = new Random();
        int random = Random.Range(min, max);
        return random;       
    }
}
