using UnityEngine;
using UnityEngine.UI;

public class HintButton2 : MonoBehaviour
{
    public InputField inputField;
    private string newPlaceholder="name=input(\'Enter your name:\')\nprint(name)";

    public void OnButtonClick()
    {
        inputField.placeholder.GetComponent<Text>().text = newPlaceholder;
    }
}