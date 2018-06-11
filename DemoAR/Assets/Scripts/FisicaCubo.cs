using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicaCubo : MonoBehaviour {
    public int vida;
    public Color[] color = new Color[4];
    // Use this for initialization
    void Start () {
        //vida = 4;
        color[0] = Color.red;
        color[1] = Color.green;
        color[2] = new Color(1, 1, 0, 1);
        color[3] = Color.blue;
        vida = Random.Range(0, 4);
        GetComponent<Renderer>().material.color = color[vida];
        /*for (int i = 0; i < 4; i++)
        {
            if (GetComponent<Renderer>().material.color == (color[i]))
            {
                vida = i;
            }
        }*/
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bola")
        {
            Destroy(collision.gameObject);
            print("choque, vida =" + vida);
            vida--;
            // print("choque, vida =" + vida);
            if (vida == -1)
            {
                Destroy(gameObject);
            }
            else
            {
                GetComponent<Renderer>().material.color = color[vida];
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
