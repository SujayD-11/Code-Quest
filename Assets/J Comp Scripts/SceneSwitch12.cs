using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch12 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level 2");
        GlobalVariables.sceneNameRetry.Add("Level 2");
    }
}
