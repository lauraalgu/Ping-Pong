using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racke2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Right
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.back);
        }

        //Motion Left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.forward);
        }

        //Up
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up);
        }

        //Down
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down);
        }

    }
}
