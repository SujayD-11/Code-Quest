using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PopEditor3_1 : MonoBehaviour
{
   public static Vector2 pos3_1;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos3_1 = transform.position;
            Debug.Log(pos3_1);
            SceneManager.LoadScene("CodePuzzle 3_1");
            
        }
    }
}
