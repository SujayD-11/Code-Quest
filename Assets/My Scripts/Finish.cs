using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject uiObject;
    // Start is called before the first frame update
    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
       
    }
    
}
