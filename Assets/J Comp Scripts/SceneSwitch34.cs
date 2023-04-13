using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch34 : MonoBehaviour
{
    // Start is called before the first frame update
//    private void OnCollisionEnter2D(Collision2D collision){
//     if(collision.gameObject.CompareTag("Player")){
//         SceneManager.LoadScene("Level 4");
//     }
//    }


   private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level 4");
        GlobalVariables.sceneNameRetry.Add("Level 4");
    }
}
