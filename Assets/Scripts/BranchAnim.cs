using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchAnim : MonoBehaviour
{

		public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
			anim.Play("branch");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
