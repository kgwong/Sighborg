using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoor : MonoBehaviour
{    

		private bool triggerStay = false;

    void Update()
    {
        if(triggerStay && Input.GetButtonDown("Submit"))
        {
        	SceneController.LoadScene("Scene4");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            triggerStay = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            triggerStay = false;
        }
    }
}
