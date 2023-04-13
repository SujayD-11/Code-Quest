using UnityEngine;
using UnityEngine.SceneManagement;

public class PopEditor2 : MonoBehaviour
{
   public static Vector2 pos2;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Open the text editor
            Debug.Log("hello");
            pos2 = transform.position;
            SceneManager.LoadScene("CodePuzzle 2");
            
        }
    }
}