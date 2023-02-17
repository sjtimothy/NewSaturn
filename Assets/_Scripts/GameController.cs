using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{
//	public GameObject[] hazards;
//	public Vector3 spawnValues;
//	public int hazardCount;
//	public float spawnWait;
//	public float startWait;
//	public float waveWait;
	
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI restartText;
	public TextMeshProUGUI gameOverText;
	public TextMeshProUGUI clockText;
    public string scene;
	
	bool gameOver;
	bool finish;
	bool isPause;
	private bool restart;
	private int score;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		finish = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
        Time.timeScale = 1;
        //	StartCoroutine (SpawnWaves ());
        //anim = Animation.GetComponent<Animator>();

    }
	
	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
            {
                SceneManager.LoadScene(scene);

            }
        }
		clockText.text = "Time: " + Time.time;
		Pause ();

	



	}
	
//	IEnumerator SpawnWaves ()
//	{
//		yield return new WaitForSeconds (startWait);
//		while (true)
//		{
//			for (int i = 0; i < hazardCount; i++)
//			{
//				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
//				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range (0, spawnValues.y), spawnValues.z);
//				Quaternion spawnRotation = Quaternion.identity;
//				Instantiate (hazard, spawnPosition, spawnRotation);
//				yield return new WaitForSeconds (spawnWait);
//			}
//			yield return new WaitForSeconds (waveWait);
//			
//			if (gameOver || finish)
//			{
//				restartText.text = "Press 'R' for Restart";
//				restart = true;
//				break;
//			}
//		}
//	}

	public void Pause ()
	{	if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.Joystick1Button9)) {
						isPause = !isPause;
						if (isPause && !gameOver) {
								Time.timeScale = 0;
								//enable pause gui
								gameOverText.text = "Paused";
                                
               //                 anim.enabled = false;
            }

						if (!isPause && !gameOver) {
								Time.timeScale = 1;
								gameOverText.text = "";
                    //            anim.enabled = true;
            }
				} else {
						return;
				}

	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
	
	public void GameOver ()
	{	
		new WaitForSeconds (2);
		gameOverText.text = "You Dead";
		gameOver = true;
	}

	public void Finish ()
	{	

		new WaitForSeconds (1);
		gameOverText.text = "Level Complete";
		gameOver = true;
	} 
			

}