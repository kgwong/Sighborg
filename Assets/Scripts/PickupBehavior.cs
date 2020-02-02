using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    public string parentScene;
    public AudioSource optOnPickupSound;

    private bool triggerStay = false;
    private Collider2D player;

    void Update()
    {
        if(triggerStay && Input.GetButtonDown("Submit"))
        {
            if (optOnPickupSound)
            {
                optOnPickupSound.Play();
            }
            CurrentItem currentItem = player.GetComponent<CurrentItem>();
            currentItem.SetCurrentItem(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            triggerStay = true;
            player = collider;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            triggerStay = false;
            player = null;
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
        if(scene.name == parentScene)
        {
            gameObject.SetActive(true);
        }
        else if(gameObject.transform.parent == null) //if the item is sitting in the scene by itself, disable on every other scene
        {
            gameObject.SetActive(false);
        }
    }
}
