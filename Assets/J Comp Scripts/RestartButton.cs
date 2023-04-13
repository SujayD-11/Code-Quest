using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
   

   public void RetryLastLevel()
   {
        SceneManager.LoadScene(GlobalVariables.sceneNameRetry[GlobalVariables.sceneNameRetry.Count - 1]);
   }
}