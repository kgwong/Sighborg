using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigh : MonoBehaviour
{
		public AudioSource sigh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void DelayedSigh()
    {
    	  sigh.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
        	Invoke("DelayedSigh", 0.25f);
        }
    }


}
