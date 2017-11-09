using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {
    public Text myGuess;

    int min = 0;
    int max = 0;
    int guess = 0;
    int maxGuesses = 5;

    // Use this for initialization
    void Start () {
        StartGame();
     
    }
	
	// Update is called once per frame
	void Update () {




        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow pressed!");
            min = guess;
            NextGuess();



        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("down arrow pressed!");
            max = guess;
            NextGuess();



        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("enter is pressed");
            print("I won");
            StartGame();

        }



    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        //guess = 500;

        NextGuess();
    }

    void  NextGuess()
    {
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene("win");
        }
        else
        {

            print("Is the number higher, lower or equal to " + guess + "?");
            print("UP Arrow: your number is higher, DOWN Arrow: your number is lower, ENTER: it is equal!");
            guess = Random.Range(min, max);
            myGuess.text = "The guess is " + guess + "?";
            maxGuesses = maxGuesses - 1;

        }



    }

    public void guessHigher()
    {

        print("up arrow pressed!");
        max = guess -1;
        NextGuess();
      
    }

    public void guessLower()
    {

        print("down arrow pressed!");
        min = guess + 1;
   
        NextGuess();
       
    }


    public void nextLevel()
    {

        SceneManager.LoadScene("loss");
    }



}
