using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PopEditor2_1 : MonoBehaviour
{
    public static Vector2 pos2_1;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos2_1 = transform.position;
            SceneManager.LoadScene("CodePuzzle 2_1");
            
        }
    }
}
