using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopEditor3 : MonoBehaviour
{
   public static Vector2 pos3;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos3 = transform.position;
            SceneManager.LoadScene("CodePuzzle 3");
            
        }
    }
}
