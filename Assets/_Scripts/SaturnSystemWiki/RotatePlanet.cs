using UnityEngine;
using System.Collections;

public class RotatePlanet : MonoBehaviour {

	private float speed = 0.7f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(speed, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, speed, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -speed, 0);

        }
           
		}

}

