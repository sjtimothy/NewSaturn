using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SaturnGUI : MonoBehaviour {
	
	public GameObject[] planets;
	private bool dispHelp,hideGui;
	private GameObject displayedPlanet;
	// Use this for initialization
	void Start () {
		dispHelp = false;
		hideGui = false;
		displayedPlanet = Instantiate(planets[0],transform.position,planets[0].transform.rotation) as GameObject;
		displayedPlanet.transform.parent=transform;
	}
	void Update(){
		if(Input.GetKeyUp(KeyCode.F1)){dispHelp = !dispHelp;}
		if(Input.GetKeyUp(KeyCode.F2)){hideGui = !hideGui;}
		if (Input.GetKeyDown (KeyCode.Escape)){
			Debug.Log("Loading Title");
			SceneManager.LoadScene(0);
		} 
	}	

	void OnGUI(){
		if(!hideGui){
			GUILayout.BeginArea(new Rect(Screen.width-180, 20,150,500));
			GUILayout.BeginVertical();
			GUILayout.Label("Press F2 to hide GUI");
			for(int i = 0; i<planets.Length; i++){
				if(GUILayout.Button(planets[i].name)){
					Destroy(displayedPlanet);
					displayedPlanet = Instantiate(planets[i],transform.position,planets[i].transform.rotation) as GameObject;
					displayedPlanet.transform.parent=transform;
					
				}
			}
			GUILayout.EndVertical();
			
			
			GUILayout.EndArea();
			
			GUILayout.BeginArea(new Rect(30, 20,250,500));
			GUILayout.BeginVertical();
			
			if(dispHelp){
				GUILayout.Label("Press F1 to hide help\n");
				GUILayout.Label("CAMERA FLYBY COMMANDS :");
				GUILayout.Label("Q: Zoom in");
				GUILayout.Label("Z: Zoom out");
				GUILayout.Label("Up arrow: Move upward");
				GUILayout.Label("Down arrow: Move downward");
				GUILayout.Label("Left arrow: Move Left");
				GUILayout.Label("Right arrow: Move Right");
				GUILayout.Label("W: Rotate up");
				GUILayout.Label("S: Rotate down");
				GUILayout.Label("A: Rotate left");
				GUILayout.Label("D: Rotate right");
				GUILayout.Label("X: Rotate Sun left");
				GUILayout.Label("C: Rotate Sun right");
                GUILayout.Label("Esc: Return to Title");


            }
			else{
				GUILayout.Label("Press F1 to show help");

			}
			
			GUILayout.EndVertical();
			
			
			GUILayout.EndArea();
		}
	}
}
