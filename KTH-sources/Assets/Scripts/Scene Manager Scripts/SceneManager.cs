using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameManager  gameScript;
	public MenuManager  menuScript;
	public ScoreManager scoreScript;
	
	void Awake(){
		gameScript.enabled  = false;
		menuScript.enabled  = false;
		scoreScript.enabled = false;
	}
	
	void Start () {
		menuScript.enabled = true;
	}
	
	/// <summary>
	/// Starts the run.
	/// </summary>
	public void StartRun(levelList levelIndex){
		menuScript.enabled = false;
		gameScript.StartMap(levelIndex);
	}
	
	/// <summary>
	/// Ends the run.
	/// </summary>
	public void EndRun(){
		gameScript.enabled  = false;
		scoreScript.enabled = true;
	}
}
