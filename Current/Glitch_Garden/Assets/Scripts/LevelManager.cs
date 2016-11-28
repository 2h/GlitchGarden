//2h
//23/11/2016
//12:38
//Whitesgate

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	#region Methods

	public float autoLoadNextLevelAfter;

	void Start()
	{
		if (autoLoadNextLevelAfter == 0) 
		{
			Debug.Log ("Level auto load disabled");	
		} 
		else 
		{
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name)
	{
		//Debug.Log ("Level load requested for: " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest(string name)
	{
		//Debug.Log ("I want to quit ");
		Application.Quit ();
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadStartScreen()
	{
		SceneManager.LoadScene ("01a_Start");
	}

	public void LoadWinScreen()
	{
		SceneManager.LoadScene ("03a_Win");
	}

	public void LoadLoseScreen()
	{
		SceneManager.LoadScene ("03b_Lose");
	}

	public void LoadOptionsScreen()
	{
		SceneManager.LoadScene ("01b_Options");
	}
	#endregion
}
