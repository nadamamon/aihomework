using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D s){
		if(s.gameObject.tag == "floor"){
			Destroy(this.gameObject);
		}
	}
}
