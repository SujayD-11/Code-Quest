using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class VC3_2 : MonoBehaviour
{
    public string input;
    public string validInput;
    private GameObject myObject;
    public Vector2 pos3_2 ;
    private GameObject myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        validInput = @"^print\s*\(?\s*""Hello \s*World""\s*\)?\s*$";
       
        pos3_2 =   PopEditor3_2.pos3_2;
        Debug.Log(pos3_2);
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);

    }

    public void OnButtonPress()
    {
        bool isValid = false;


        if (Regex.IsMatch(input, validInput))
        {   
            Debug.Log("Input is correct Python code for printing 'Hello, World!'");
            isValid = true;
        }
        else
        {  
             Debug.Log("input: " + input);
            Debug.Log("Input is not correct Python code for printing 'Hello, World!'");
        }


        if (isValid)
        {
            Debug.Log("Successful");
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level 3");
            SceneManager.sceneLoaded += OnSceneLoaded;
        }


    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode){
            //myObject= GameObject.FindGameObjectWithTag("Finish");
            myObject = GameObject.Find("Code Checkpoint 3_2");
            myPlayer = GameObject.Find("Player");

            if(myObject != null && myPlayer != null){
                Debug.Log("Found object");
                Debug.Log(pos3_2);
                //myObject.SetActive(false);
                myObject.GetComponent<BoxCollider2D>().enabled = false;
                myPlayer.transform.position = pos3_2;


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
