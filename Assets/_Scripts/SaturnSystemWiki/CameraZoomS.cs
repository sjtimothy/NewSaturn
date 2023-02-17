using UnityEngine;
using System.Collections;

public class CameraZoomS : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Q)){
			transform.Translate(0,0,2f);
		}
		if(Input.GetKey(KeyCode.Z)){
			transform.Translate(0,0,-2f);
		}
	}
}
