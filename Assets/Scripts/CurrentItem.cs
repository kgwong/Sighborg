using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentItem : MonoBehaviour
{
    private GameObject currentItem;

    public void SetCurrentItem(GameObject go)
    {
        if(currentItem != null)
        {
            DropItem();
        }
        currentItem = go;
        currentItem.transform.parent = gameObject.transform;
    }

    public string GetName()
    {
        if (currentItem == null) return null;
        return currentItem.GetComponent<PickupBehavior>().name;
    }

    private void DropItem()
    {
        currentItem.transform.parent = gameObject.transform.parent;
        currentItem.GetComponent<PickupBehavior>().parentScene = SceneManager.GetActiveScene().name;
    }

}
