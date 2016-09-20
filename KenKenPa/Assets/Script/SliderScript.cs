using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
	
	public GameObject Camera;

	Slider _slider;

	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
	}

	float _hp = 0;
	float cameraY = 0;

	void Update () {

		cameraY = Camera.transform.position.y;

		// HPゲージに値を設定
		_slider.value = cameraY;
	}
}