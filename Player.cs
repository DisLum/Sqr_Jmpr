using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody2D playerBody;		// needed to add force
	public float passingTime;	// player moves up this time long
	public string moveRight;
	public string moveLeft;

	void Start(){	
		playerBody = GetComponent<Rigidbody2D> ();	// find the Rigidbody of player
	}

	void Update(){
		// Jumping scheme
	
		passingTime += Time.deltaTime * 1;// time goes

		if(passingTime >= 1f){	
		playerBody.AddForce (Vector3.down * 6); // move down after 1.1 sec
		Physics2D.IgnoreLayerCollision (0, 0, false);
		}
			
		if (Input.GetKey (moveRight)) {
			playerBody.AddForce (Vector3.right * 10);
		}
		if (Input.GetKey (moveLeft)) {
			playerBody.AddForce (Vector3.left * 10);
		}

	}

	void OnCollisionEnter2D(Collision2D cll){

		if (this.transform.position.y > cll.transform.position.y) {
			playerBody.AddForce (Vector3.up * 125);	// jump if player hits platform
			passingTime = 0;	// jumping time goes 0
			Destroy(cll.gameObject);
		} 
	}

	void OnTriggerEnter2D(Collider2D cll){
			Physics2D.IgnoreLayerCollision (0, 0);	
	}
}
