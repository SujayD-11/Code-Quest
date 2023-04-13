using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch4toEnd : MonoBehaviour
{

    public GameObject popper;

    private void Start() {
        popper.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            popper.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End Credit");
        
       
    }
}
