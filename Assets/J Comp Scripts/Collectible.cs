
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool isCollided = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isCollided = true;
            GlobalVariables.collectedItems.Add(this.gameObject.name);//adds name of item collected to global variable 
                                                                     //helping store the state of the game.
        }


    }
}
public static class GlobalVariables
{
    public static List<string> collectedItems = new List<string>();// global List to store the name of items collected
    public static int sc = 0;// global variable for score
    public static int flagSceneChange = 0;
    public static List<string> sceneNameRetry = new List<string>();
    
}