using UnityEngine;
using System.Collections;

public class walkscript : MonoBehaviour {
	public float speed = 10f;
	public float jumpForce = 100f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("RIGHT")) {
			transform.Translate(speed*Time.deltaTime,0f,0f);
		}
		if (Input.GetButton ("LEFT")) {
			transform.Translate(-speed*Time.deltaTime,0f,0f);
		}
		if (Input.GetButton ("JUMP")) {
			rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.y,jumpForce));
			Debug.Log("aaaa");
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "enemy"){
			Destroy(this.gameObject);
		}

	}

}
