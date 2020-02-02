using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BranchThrowInteractable : MonoBehaviour, Interactable
{
    public Animator anim;
    public Animator dogAnim;
    private GameObject door;

    void Start()
    {
        door = GameObject.Find("DogWall");
    }

    public void OnPlayerInteract(string currentItem)
    {
        Debug.Log(currentItem);
        if (door && currentItem == "Branch")
        {
            if (anim && dogAnim)
            {
                anim.Play("branch");
                dogAnim.Play("dog_fetch");
            }
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
        if(scene.name == "Scene2")
        {
            gameObject.SetActive(true);
        }
        else if(gameObject.transform.parent == null) //if the item is sitting in the scene by itself, disable on every other scene
        {
            gameObject.SetActive(false);
        }
    }
}
