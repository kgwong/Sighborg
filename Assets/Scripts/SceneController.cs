using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static string prevScene = "";
    public static string currentScene = "Scene1";

    public static void LoadScene(string sceneName)
    {
        prevScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }

}
