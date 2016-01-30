using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

	public float fadeTime = 1.0f;
	public Text TextItemGUI; //set with inspector

	// change this alpha if you don't want it to fade from black
	public Color textColor = new Color(1,1,1,0);

	// Use this for initialization
	void Start () {

		//GetComponent



		StartCoroutine (Fade (TextItemGUI));


	}

	IEnumerator Fade(Text TitleText)
	{
		float t = 0;
		while (t < 1) {
			textColor.a = t;
			TitleText.color = textColor;
			t += Time.deltaTime / fadeTime;
			yield return null;
		}

		textColor.a = 1;
		TitleText.color = textColor;
	}


}