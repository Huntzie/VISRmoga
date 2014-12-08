using UnityEngine;
using System.Collections;

public class movementController : MonoBehaviour {


    public float Speed;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        this.rigidbody.AddForce(transform.forward * 200);

        if(Input.GetKeyDown("t"))
        {
            Speed += 0.1f;
        }
        if (Input.GetKeyDown("g"))
        {
            Speed -= 0.1f;
        }

	}
}
