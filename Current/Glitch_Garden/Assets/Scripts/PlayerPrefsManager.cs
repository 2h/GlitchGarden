//2h
//28/11/2016
//17:11
//Whitesgate
//PlayerPrefs Wrapper Class
//Centralise usage of PlayerPrefs

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	//SETTERS & GETTERS

	#region MasterVolume

	//1 instance running on the class
	public static void SetMasterVolume(float volume)
	{
		if (volume >= 0.0f && volume <= 1.0f) 
		{
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} 
		else 
		{
			Debug.LogError ("Master Volume out of range.");
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel(int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1)
		//if (level <= Application.levelCount - 1) 
		{
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);  //use 1 for true
		} 
		else 
		{
			Debug.LogError ("Trying to unlock level not in build order");
		}
	}

	#region Difficulty
	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 1.0f && difficulty <= 3.0f) 
		{
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);	
		} 
		else 
		{
			Debug.LogError ("Difficulty out of range.");
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
	#endregion

	#endregion
	#region UnlockLevel

	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);


		if (level <= SceneManager.sceneCountInBuildSettings - 1)
			//if (level <= Application.levelCount - 1) 
		{
			return isLevelUnlocked;
			//return true;
		} 
		else 
		{
			Debug.LogError ("Trying to unlock level not in build order.");
			return false;
		}
	}
	#endregion
}
