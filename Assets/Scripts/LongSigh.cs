using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSigh : MonoBehaviour
{
    public AudioSource longSigh;

    private void playLongSigh()
    {
    	longSigh.Play();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
    	if(collider.gameObject.tag == "Player")
    	{
    		Invoke("playLongSigh", 0.25f);
    	}
    }
}
