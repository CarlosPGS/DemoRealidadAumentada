using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicaBola : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(new Vector3(200f, Random.Range(-45f, 10f),   Random.Range(-60f, 60f)), ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision collision)
    {
       // if (collision.gameObject.tag == "estructura")
       // {
            Destroy(gameObject);
        //}
            
    }
    // Update is called once per frame
    void Update () {
		
	}
}
