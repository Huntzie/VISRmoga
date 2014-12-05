using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public float nextShot;
    public float shotCooldown = 1000;
	// Use this for initialization
	void Start () {    
        nextShot = Time.time;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Moga_Input.GetKey(KeyCode.A))
        {
            if (Time.time > nextShot)
            {
                Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
                nextShot = Time.time + shotCooldown;
            }
        }
        
       
        
      
       
	}
}
