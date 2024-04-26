using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerChecker : MonoBehaviour
{
    public InputField answerInputField; // Reference to the Input Field UI element

    //answers
    public string NM1N1;
    public string NM1N2;
    public string NM1N3;

    // Method to be called when the player submits their answer
    public void CheckAnswer()
    {
        // Get the text from the input field
        string playerAnswer = answerInputField.text;

        // Check if the player's answer matches the correct answer
        if (playerAnswer.ToLower() == NM1N1.ToLower())
        {
   
        }
        else if (playerAnswer.ToLower() == NM1N2.ToLower())
        {

        }
        else if (playerAnswer.ToLower() == NM1N3.ToLower())
        {
            
        }
        else
        {
            Debug.Log("Incorrect answer. Try again!");
            // Optionally, provide feedback to the player that their answer was incorrect
        }
    }
}