using UnityEngine;
using UnityEngine.UI;

public class ValidateCode : MonoBehaviour
{
    public InputField inputField;

    private string validInput = "This is the valid input string.";

    public void ValidateInput()
    {
        if (inputField == null)
        {
            Debug.LogError("InputField is not assigned!");
            return;
        }

        // Get the input text from the input field
        string inputText = inputField.text;

        // Split the input text into lines
        string[] inputLines = inputText.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);

        // Check if each line of input matches the corresponding line of the valid input
        bool isValid = true;
        for (int i = 0; i < inputLines.Length; i++)
        {
            if (!string.Equals(inputLines[i], validInput.Split('\n')[i]))
            {
                isValid = false;
                break;
            }
        }

        // Display the validation result
        if (isValid)
        {
            Debug.Log("Input is valid!");
        }
        else
        {
            Debug.Log("Input is invalid!");
        }
    }
}