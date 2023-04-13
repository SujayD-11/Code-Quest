using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text.RegularExpressions;

public class VC2 : MonoBehaviour
{ 
    public string input;
    public string validInput;
    string[] lines;
    private GameObject myObject;
    public Vector2 pos2 ;
    private GameObject myPlayer;
    //public GameObject gameobj;
    // Start is called before the first frame update
    void Start()
    {
        pos2  = PopEditor2.pos2;
        validInput = @"^name\s*=\s*input\(\s*['""](.+)['""]\s*\)\s*\nprint\s*\(\s*name\s*\)$";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s){
        input = s;
        
    }

    public void OnButtonPress(){
        bool isValid = false;


        if (Regex.IsMatch(input, validInput)) {
            Debug.Log("Input is correct Python code for printing 'Hello, World!'");
            isValid = true;
        } else {
            Debug.Log("Input is not correct Python code for printing 'Hello, World!'");
        }


        if(isValid){
            Debug.Log("Successful");
           AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level 1");
            SceneManager.sceneLoaded += OnSceneLoaded;

            
        }

        
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode){
            //myObject= GameObject.FindGameObjectWithTag("Finish");
            myObject = GameObject.Find("Code Checkpoint 2");
            myPlayer = GameObject.Find("Player");

            if(myObject != null && myPlayer != null){
                Debug.Log("Found object");
                Debug.Log(pos2);
                //myObject.SetActive(false);
                myObject.GetComponent<BoxCollider2D>().enabled = false;
                myPlayer.transform.position = pos2;


                 foreach (string itemName in GlobalVariables.collectedItems)
            {
                // Find the game object with the matching name
                GameObject itemObject = GameObject.Find(itemName);

                // Destroy the game object if it exists
                if (itemObject != null)
                {
                    Destroy(itemObject);
                }
            }
            GlobalVariables.flagSceneChange = 1;
            Debug.Log(GlobalVariables.flagSceneChange);


            }
            else{
                Debug.Log("Not Found");
            }

            
        }
}
