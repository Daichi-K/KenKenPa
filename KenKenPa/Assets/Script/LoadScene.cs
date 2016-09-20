using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string sceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
        
	}

    public void buttonPush( ) {
        Application.LoadLevel( sceneName );
        TimeScript.gameTime = 0;
    }
}
