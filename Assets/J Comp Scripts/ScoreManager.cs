using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public static int cherries = 0;
  

    [SerializeField] private Text cherriesText;
    

    private void Awake()
    {
        //cherries = PlayerPrefs.GetInt("cherries",0);
        // if (instance == null)
        // {
        //     instance = this;
        //     Debug.Log("Dont Destroy");
        //     DontDestroyOnLoad(gameObject);
        // }
        // else
        // {
        //     Debug.Log("Destroy");
        //     Destroy(gameObject);
           
        // }

         if (instance != null && instance != this)
        {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    

    public void AddScore()
    {
        cherries++;
    }

    public int GetScore()
    {
        Debug.Log(cherries);
        return cherries;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        cherries = 0;
    }
}