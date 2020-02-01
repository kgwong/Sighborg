using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehavior : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour interactable;

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && Input.GetKeyDown("return"))
        {
            CurrentItem currentItem = collider.gameObject.GetComponent<CurrentItem>();
            ((Interactable)interactable).OnPlayerInteract(currentItem.GetName());
        }
    }
}
