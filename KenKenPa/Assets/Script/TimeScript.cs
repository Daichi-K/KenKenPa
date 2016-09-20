using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

	public Text scoreText; //Text用変数
	public static float gameTime = 0; //スコア計算用変数
    public static int countDown = 0;

	void Start (){
		scoreText.text = "Score: 0"; //初期スコアを代入して画面に表示
        countDown = 0;
	}

	void Update (){
		scoreText.text = "" + gameTime.ToString( "f1" );
		if (MoveCamera.gameSwitch == 0 && countDown == 1) {
			gameTime += Time.deltaTime;
		}

		if (gameTime >= 999.9) {
			gameTime = 999.9f;
		} 
	}
}