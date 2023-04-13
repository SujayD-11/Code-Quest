using UnityEngine;
using UnityEngine.SceneManagement;

public class PopEditor : MonoBehaviour
{
   public static Vector2 pos;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos = transform.position;
            SceneManager.LoadScene("CodePuzzle");
            
        }
    }
}