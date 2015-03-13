using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");	

		//Rigidbody rigidbody = new Rigidbody ();

		float x = moveHorizontal;
		float y = 0.0f;
		float z = moveVertical;
		Debug.Log(Input.GetKeyDown("c"));
		if(Input.GetKeyDown("c")){
			y = jump();
		}

		Vector3 movement = new Vector3(x, y, z);
		GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);
		}
	}

	float jump(){
		//logic about if it is rolling then you can jump again
		return jumpHeight;
	}
}
