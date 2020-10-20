using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    int textspeed = 2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            print("move w");
            this.transform.Translate(Vector3.forward * Time.deltaTime * textspeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            print("move s");
            this.transform.Translate(Vector3.back * Time.deltaTime * textspeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("move a");
            this.transform.Translate(Vector3.left * Time.deltaTime * textspeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("move d");
            this.transform.Translate(Vector3.right * Time.deltaTime * textspeed);
        }
    }
}
