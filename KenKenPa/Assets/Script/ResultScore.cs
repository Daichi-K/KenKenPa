using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

	public Text scoreText;
	private int score = 0;
	
	void Start (){
		scoreText.text = "Time:XXX";
	}
	
	void Update ()
	{
			scoreText.text = "Time:" + TimeScript.gameTime.ToString( "f1" );
	}

}