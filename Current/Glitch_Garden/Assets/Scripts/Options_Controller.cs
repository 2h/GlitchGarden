//2h
//29/11/2016
//11:18
//Whitesgate

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Options_Controller : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private Music_Manager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<Music_Manager>();

		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume(volumeSlider.value);
	}

	public void SaveAndExit()
	{
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		//set difficulty
		levelManager.LoadLevel ("01a_Start");
	}

	public void setDefaults()
	{
		//hard-coded
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2.0f;
	}
}
