using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    // Start is called before the first frame update

    public void StartGame(){
         GlobalVariables.sceneNameRetry.Add("Level 1");
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame(){
        Application.Quit();
    }
   
}
