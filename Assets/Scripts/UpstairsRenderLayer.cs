using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpstairsRenderLayer : MonoBehaviour
{
		public SpriteRenderer stairsRenderer;
		public SpriteRenderer fixedStairsRenderer;

		private int oldStairsOrder = 0;
		private int oldFixedOrder = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
    	Debug.Log("test");
    	if(collider.gameObject.tag == "Player")
    	{
    		oldStairsOrder = stairsRenderer.sortingOrder;
    		oldFixedOrder = fixedStairsRenderer.sortingOrder;
    		stairsRenderer.sortingOrder = 4;
    		fixedStairsRenderer.sortingOrder = 5;
    	}
    }

    void OnTriggerExit2D(Collider2D collider)
    {
    	if(collider.gameObject.tag == "Player")
    	{
    		stairsRenderer.sortingOrder = oldStairsOrder;
    		fixedStairsRenderer.sortingOrder = oldFixedOrder;
    	}
    }
}
