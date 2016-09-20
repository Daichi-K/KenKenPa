using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CountDown : MonoBehaviour {

	public Text countText;
	private int count = 3;
    int gameTime = 0;
	
	void Start (){
	    countText.text = "3";
	}
	
	void Update () {
		countText.text = "" + count.ToString( );
	    
        gameTime++;

        if( gameTime <= 60 ) {
            count = 3;
        } else if( gameTime > 60 && gameTime <= 120 ) {
            count = 2;
        } else if ( gameTime > 120 && gameTime <= 180 ) {
            count = 1;      
        } else if( gameTime > 180 ) {
            TimeScript.countDown = 1;
            this.gameObject.SetActive( false );
        }
    }

}