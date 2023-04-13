using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PopEditor2_2 : MonoBehaviour
{
    public static Vector2 pos2_2;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos2_2 = transform.position;
            Debug.Log(pos2_2);
            SceneManager.LoadScene("CodePuzzle 2_2");
            
        }
    }
}
