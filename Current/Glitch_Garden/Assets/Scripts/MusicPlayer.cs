//2h
//8/11/2016
//16:29
//Whitesgate

using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	void Awake()
	{
		//Debug.Log ("Music Player Awake: " + GetInstanceID());

		//if a MusicPlayer instance exists (ie not null return)
		//Object is destroyed in the Awake Method so as not to have delay waiting on Start Method
		//which would lead to the brief existence of two instances of the MusicPlayer

		if (instance != null) {
			Destroy (gameObject);
			//print ("GameObject duplicate destroyed");
		} 
		else 
		{
			//claim the instance
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		//Debug.Log ("Music Player Start: " + GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
