using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehavior : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour interactable;

    void Start()
    {
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && Input.GetButton("Submit"))
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color.blue;
            ((Interactable)interactable).OnPlayerInteract("test");
        }
    }
}
