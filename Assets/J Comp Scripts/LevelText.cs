using UnityEngine;
using System.Collections;
public class LevelText : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
    }
} 