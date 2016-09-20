using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public Transform clearTxt;
	public Transform failedTxt;

	bool isMoving = false;
	int moveCount = 0;
	int clickCount = 0;
	public int[] kenpaNumbers = new int[31]; 

	public static int gameSwitch = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//けんぱ種類挿入
		for (int i = 0; i < 30; i++) {
			if (kenpaNumbers [i] != 3) {
				kenpaNumbers [i] = CreateScript.kenpaNumbers [i];
			}
		}
		kenpaNumbers [30] = 2;

        if ( TimeScript.countDown == 1) {
    
    		//どっちのキーが入力されたか
    		if (kenpaNumbers[clickCount] == 0) {		//パー
    			if( InputPaKey ( ) ) {
    				isMoving = true;
    				clickCount++;
    			}
    			if( InputKenKey ( ) ) {
    				GameFailed ();
    			}
    		} else if (kenpaNumbers[clickCount] == 1) {		//ケン
    			if( InputKenKey ( ) ) {
    				isMoving = true;
				    clickCount++;
			    }
		    	if(  Input.GetKeyDown( KeyCode.V) || Input.GetKeyDown( KeyCode.N) ) {
			    	GameFailed ();
		    	}
	    	} else if (kenpaNumbers[clickCount] == 2) {			//クリア
	    		clearTxt.gameObject.SetActive (true);
    			isMoving = true;
			    gameSwitch = 1;
		    } else if (kenpaNumbers[clickCount] == 3) {			//失敗
	    		failedTxt.gameObject.SetActive (true);
    			gameSwitch = 2;
		    }
        }

		//カメラが上に移動
		if (isMoving) {
			if (moveCount <= 2) {
				transform.Translate (transform.up * 1 );
				moveCount++;
			}
			if (moveCount > 2) {
				isMoving = false;
				moveCount = 0;
			}
		}

        if( this.transform.position.y >= 117.7f) {
            this.transform.position = new Vector3( 0, 117.7f, -10);
        }
	}

	public bool InputKenKey ( ) {

		if( Input.GetKeyDown( KeyCode.B)) {
			return true;
		}
		return false;
	}

	public bool InputPaKey ( ) {
		if( Input.GetKey( KeyCode.V) && Input.GetKeyDown( KeyCode.N) ) {
			return true;
		} else if( Input.GetKeyDown( KeyCode.V) && Input.GetKey( KeyCode.N) ) {
			return true;
		}
		return false;
	}

	public void GameFailed ( ) {
		for (int i = 0; i < 30; i++) {
			kenpaNumbers [i] = 3;
		}
	}
}
