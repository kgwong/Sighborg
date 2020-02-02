using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FromScene : MonoBehaviour
{
    public string prevSceneName;

    void Start()
    {
        SceneController.currentScene = SceneManager.GetActiveScene().name;
        if (SceneController.prevScene == prevSceneName)
        {
            GameObject player = GameObject.Find("Player");
            player.transform.position = gameObject.transform.position;
        }
    }
}
