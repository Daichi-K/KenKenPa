using UnityEngine;
using System.Collections;

public class CreateScript : MonoBehaviour {

    public Transform ken;
    public Transform pa;

	public static int[] kenpaNumbers = new int[30];  

    int rand;

    Vector3 placePosition = new Vector3( 0, 0, 0 );
    Quaternion q = new Quaternion( );
    
	void Start () {
        for( int i = 0; i < 30; i++ ) {
            rand = Random.Range( 1,6 );
            placePosition.y += 3;

			if( rand <= 2 ) {
				kenpaNumbers[ i ] = 0;
				Instantiate( pa,placePosition,q );
			}else if ( rand >= 3 ) {
				kenpaNumbers[ i ] = 1;
				Instantiate( ken,placePosition,q );
			}
        }
	}
	
	void Update () {
           
        
	}
}
