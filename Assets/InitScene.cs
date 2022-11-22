using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitScene : MonoBehaviour
{
    public string scene01;
    public string scene02;
    public string scene03;


    // Start is called before the first frame update
   void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene(scene01, LoadSceneMode.Additive);
        SceneManager.LoadScene(scene02, LoadSceneMode.Additive);
        SceneManager.LoadScene(scene03, LoadSceneMode.Additive);

    }

}
