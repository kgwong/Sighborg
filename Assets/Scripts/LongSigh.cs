using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSigh : MonoBehaviour
{
		public AudioSource longSigh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void playLongSigh()
    {
    	longSigh.Play();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("sigh trigger");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
    	Debug.Log(collider.gameObject.tag);
    	if(collider.gameObject.tag == "Player")
    	{
    		Invoke("playLongSigh", 0.25f);
    	}
    }
}
