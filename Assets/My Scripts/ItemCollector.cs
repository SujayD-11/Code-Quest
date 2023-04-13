using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class ItemCollector : MonoBehaviour
{

    [SerializeField] public Text cherriesText;
    // [SerializeField] private AudioSource ItemSfx;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Pickup")){
            // ItemSfx.Play();
            Destroy(other.gameObject);
            GlobalVariables.sc+=1;
            cherriesText.text = "Cherries: " + GlobalVariables.sc;
            Debug.Log(GlobalVariables.sc);
        }
    }
}