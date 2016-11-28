//2h
//28/11/2016
//15:59
//Whitesgate

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float fadeInTime;

	private Image fadePanel;
	private Color currentColour = Color.black;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Panel Fade
		if (Time.timeSinceLevelLoad < fadeInTime) 
		{
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColour.a -= alphaChange;
			fadePanel.color = currentColour;
		} 
		else 
		{
			gameObject.SetActive (false);
		}
	}
}
