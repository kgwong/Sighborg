using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenInteractable : MonoBehaviour, Interactable
{
    [SerializeField]
    private GameObject door;

    public void OnPlayerInteract(string currentItem)
    {
        Destroy(door);
    }
}
