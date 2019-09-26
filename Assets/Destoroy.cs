using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoroy : MonoBehaviour {

	//メインカメラのオブジェクト
	private GameObject MainCamera;
	//アタッチされたオブジェクトとメインカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//メインカメラのオブジェクトを取得
		this. MainCamera= GameObject.Find ("Main Camera");


	}
	
	// Update is called once per frame
	void Update () {//メインカメラの位置に越えたらオブジェクト消滅
		if (MainCamera.transform.position.z > this.transform.position.z) {
			Destroy (this.gameObject);

		}
}
}