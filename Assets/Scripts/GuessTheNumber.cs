using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour
{
    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int userGuess;
    // Start is called before the first frame update
    void Start()
    {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        if (input.text != "")
        {
            userGuess = int.Parse(input.text);
            if (userGuess == guessNumber)
                infoText.text = "You guessed the number! You are a wizard";
            else if (userGuess < guessNumber)
                infoText.text = "Your number is smaller than the guess number";
            else
                infoText.text = "Your number is greater than the guess number";

            input.text = "";
        }
    }
}
