using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DoorOpenInteractable : MonoBehaviour, Interactable
{
    public Animator anim;
    private GameObject door;

    void Start()
    {
        door = GameObject.Find("Gate");
    }

    public void OnPlayerInteract(string currentItem)
    {
        Debug.Log(currentItem);
        if (door && currentItem == "Oilcan")
        {
            //door.GetComponent<BoxCollider2D>().enabled = false;
            //anim["gate"].wrapMode = WrapMode.Once;
            anim.Play("gate");
            door.SetActive(false);
            door = null;
        }
    }

    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        //SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Scene1")
        {
            gameObject.SetActive(true);
        }
        else if(gameObject.transform.parent == null) //if the item is sitting in the scene by itself, disable on every other scene
        {
            gameObject.SetActive(false);
        }
    }
}
