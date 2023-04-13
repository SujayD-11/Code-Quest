using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public InputField inputField;
    private string newPlaceholder="print(\"Hello World\")";

    public void OnButtonClick()
    {
        inputField.placeholder.GetComponent<Text>().text = newPlaceholder;
    }
}