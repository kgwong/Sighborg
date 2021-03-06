﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GateOpenInteractable : MonoBehaviour, Interactable
{
    public Animator anim;
    private GameObject door;
    public AudioSource audioSource;
    public AudioSource oilCanAudioSource;

    void Start()
    {
        door = GameObject.Find("Gate");
    }

    private void PlayDelayedAnimation()
    {
        anim.Play("gate");
        audioSource.Play();
    }

    public bool OnPlayerInteract(string currentItem)
    {
        if (door && currentItem == "Oilcan")
        {
            Invoke("PlayDelayedAnimation", 0.5f);
            oilCanAudioSource.Play();


            door.SetActive(false);
            door = null;
            return true;
        }
        return false;
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
