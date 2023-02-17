using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MyApplicationManager : MonoBehaviour {
					

	public void Quit () 
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
    public void ReturnTitle()
    {
        Debug.Log("Loading Title");
        SceneManager.LoadScene(0);
    }
    public void NewGame () 
	{
		Debug.Log("Loading TitanOrbit");
		SceneManager.LoadScene(1);
	}

    public void Wiki()
    {
        Debug.Log("Loading System Wiki");
        SceneManager.LoadScene(2);
    }
    
}
