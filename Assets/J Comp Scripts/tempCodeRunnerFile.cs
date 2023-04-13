// void Start()
//     {
//         Debug.Log("Accessed restart scene");
//         lastSceneIndex = PlayerPrefs.GetInt("LastSceneIndex");
//         Debug.Log(lastSceneIndex);
//         Debug.Log("flagScen variable"+GlobalVariables.flagSceneChange);
//     }

//     public void RestartLastScene()
//     {
//         if(GlobalVariables.flagSceneChange == 1)
//         {
//             SceneManager.LoadScene(lastSceneIndex);
//         }
//         else
//         {
//             GlobalVariables.sc = 0;
//             SceneManager.LoadScene(lastSceneIndex);
//         }
//     }