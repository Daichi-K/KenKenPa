using UnityEngine;
using System.Collections;

public class SingleCircleScale : MonoBehaviour {

	GameObject player;

	public float objectY = 0;
	public float playerY = 0;

	float num = 0;
	float num1 = 1;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update () {
		objectY = this.transform.position.y;
		playerY = player.transform.position.y;

		num = objectY - playerY;

		this.transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f) / num1;

		if (num == 0.0f ) {
			num1 = 1;
		} else if (num > 0.0f && num <= 3.0f) {
			num1 = 1.2f;
		} else if (num > 3.0f && num <= 6.0f) {
			num1 = 1.6f;
		} else if (num > 6.0f && num <= 9.0f) {
			num1 = 2.0f;
		} else if (num > 9.0f ) {
			num1 = 2.6f;
		}
	}
}
