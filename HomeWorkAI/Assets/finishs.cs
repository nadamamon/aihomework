using UnityEngine;
using System.Collections;

public class finishs : MonoBehaviour {
	public GUIText wintext;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D cc){
		if(cc.gameObject.tag == "enemy"){
			wintext.text = "YouWin";
		}
		
	}
}
