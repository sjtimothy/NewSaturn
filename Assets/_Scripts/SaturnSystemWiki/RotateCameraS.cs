using UnityEngine;
using System.Collections;

public class RotateCameraS : MonoBehaviour {
	
	private float mouseXAmount, mouseYAmount;
	public Transform cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,0.07f,0);
			
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,-0.07f,0);
			
		}
		
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Rotate(0.07f,0,0);
			
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Rotate(-0.07f,0,0);
			
		}
		


	}
}
