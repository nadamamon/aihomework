using UnityEngine;
using System.Collections;

public class enemyscript : MonoBehaviour {

	[SerializeField]

	GameObject spawnObject;
	private float count;


	IEnumerator Start()

	{
	
		while (true) {
			yield return new WaitForSeconds(0f);
			Instantiate(spawnObject,new Vector2(Random.Range (-3.8f,3.9f),111f),Quaternion.identity);
		}
	}

	
	void OnCollisionEnter2D(Collision2D s){
		if(s.gameObject.tag == "floor"){
			Destroy(this.gameObject);
		}
	}
}
