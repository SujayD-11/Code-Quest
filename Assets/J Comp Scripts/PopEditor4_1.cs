using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PopEditor4_1 : MonoBehaviour
{
   public static Vector2 pos4_1;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos4_1 = transform.position;
            Debug.Log(pos4_1);
            SceneManager.LoadScene("CodePuzzle 4_1");
            
        }
    }
}
