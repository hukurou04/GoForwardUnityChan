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
		
		//キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	//衝突時
	void OnCollisionEnter2D(Collision2D collision){
		//if (tag == "groundTag" || tag == "CubePrefabTag") {   ←は間違い
		if(collision.gameObject.tag == "groundTag" || collision.gameObject.tag == "CubePrefabTag"){
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}
	}
}
