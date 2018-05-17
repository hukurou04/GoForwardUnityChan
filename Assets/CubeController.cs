using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;

	//地面の位置
	private float groundLevel = -3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブが地面についているかの確認
		bool isGround = (transform.position.y > this.groundLevel) ? false: true;

		//キューブまたは地面に衝突時に音をだす
		GetComponent<AudioSource>().volume = (isGround || tag == "CubePrefabTax") ? 1 : 0;

		//キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}
}
