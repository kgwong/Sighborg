using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BranchThrowInteractable : MonoBehaviour, Interactable
{
    public Animator anim;
    public Animator dogAnim;
    public AudioSource branchThrowSound;
    public AudioSource dogBarkSound;
    private GameObject door;

    void Start()
    {
        door = GameObject.Find("DogWall");
    }

    private void PlayDogBark()
    {
        dogBarkSound.Play();
    }

    public bool OnPlayerInteract(string currentItem)
    {
        if (door && currentItem == "Branch")
        {
            if (anim && dogAnim)
            {
                Invoke("PlayDogBark", 0.25f);
                anim.Play("branch");
                dogAnim.Play("dog_fetch");
                branchThrowSound.Play();
            }
            door.SetActive(false);
            door = null;
            return false; //don't delete this one 
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
