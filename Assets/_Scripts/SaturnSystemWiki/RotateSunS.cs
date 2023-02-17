using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RotateSunS : MonoBehaviour {
	
	
	private float mouseXAmount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.X)){
			transform.Rotate(0,0.2f,0);
			
		}
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(0, -0.2f, 0);
        }	
        
		
	}
}
