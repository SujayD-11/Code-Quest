using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;




    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        if(gameObject.transform.position.y <= -25.0f) {
            Die();
            GameOver();
        }
    }
    // private void JumpToDeath() {

    // }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Traps")){
            Die();
        }
    }

    private void Die(){
        anim.SetTrigger("Death");
        Debug.Log("dead");

        rb.bodyType = RigidbodyType2D.Static;


        //GameOver();
       

    }

    private void GameOver(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene("SampleScene");
        // SceneManager.LoadScene(sceneName:"Gameover_Scene");
        SceneManager.LoadScene("Gameover_Scene");
        Debug.Log("scene change");
        //SceneManager.LoadScene("SampleScene");
    }

     
    
}
