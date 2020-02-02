using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehavior : MonoBehaviour
{
    [SerializeField]
   // private MonoBehaviour interactable;

    private bool triggerStay = false;
    private Collider2D player;

    void Update()
    {
        if(triggerStay && Input.GetButtonDown("Submit"))
        {
            CurrentItem currentItem = player.gameObject.GetComponent<CurrentItem>();
       //     if (interactable)
            {
     //           ((Interactable)interactable).OnPlayerInteract(currentItem.GetName());
            }
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
}
