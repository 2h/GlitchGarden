//2h
//24/11/2016
//15:11
//Whitesgate

using UnityEngine;
using UnityEngine.SceneManagement;

public class Music_Manager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	void Awake() {
		audioSource = GetComponent<AudioSource>();
		DontDestroyOnLoad(gameObject);
	}

	void Start() {        
		// Delegates are methods used as variables!
		SceneManager.sceneLoaded += OnSceneLoad;
	}

	// This method can be named as you wish
	// The Arguments are needed for the SceneManager, even if we don't use them
	void OnSceneLoad(Scene scene, LoadSceneMode mode)
	{
		// Get the current scene index and store as an int
		int thisSceneIndex = SceneManager.GetActiveScene().buildIndex;
		// Load the music clip for this level in the matching array slot
		AudioClip thisLevelMusic = levelMusicChangeArray[thisSceneIndex];

		if (thisLevelMusic)
		{
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
