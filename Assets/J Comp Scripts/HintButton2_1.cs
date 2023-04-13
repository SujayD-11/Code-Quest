using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintButton2_1 : MonoBehaviour
{
    public InputField inputField;
    private string newPlaceholder="for i in range(n):\n print(i)";

    public void OnButtonClick()
    {
        inputField.placeholder.GetComponent<Text>().text = newPlaceholder;
    }
}
