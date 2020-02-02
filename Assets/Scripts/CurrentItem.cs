using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentItem : MonoBehaviour
{
    public Transform graspPoint;
    public AudioSource pickupSound;
    private GameObject currentItem;

    public void SetCurrentItem(GameObject go)
    {
        if(currentItem != null)
        {
            DropItem();
        }
        pickupSound.Play();
        currentItem = go;
        currentItem.transform.parent = graspPoint;
        currentItem.transform.localPosition = new Vector3(0f, 0f, 0f);
        currentItem.GetComponent<SpriteRenderer>().sortingOrder = 0;
    }

    public string GetName()
    {
        if (currentItem == null) return null;
        return currentItem.name;
    }

    private void DropItem()
    {
        currentItem.transform.parent = gameObject.transform.parent;
        currentItem.GetComponent<PickupBehavior>().parentScene = SceneManager.GetActiveScene().name;
    }

    public void UseItem()
    {
        Destroy(currentItem);
    }

}
