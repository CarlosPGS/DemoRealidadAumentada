using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour {
    public GameObject prefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject bola;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bola = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            Destroy(bola, 5f);
        }
    }
}
