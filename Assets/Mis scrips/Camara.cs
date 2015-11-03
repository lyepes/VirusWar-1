using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

    private Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //charC.Move(-myTransform.forward);
            myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y + 1, myTransform.position.z);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //	charC.Move(myTransform.forward);
            myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y - 1, myTransform.position.z);
        }
	}
}
