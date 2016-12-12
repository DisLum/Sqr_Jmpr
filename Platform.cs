using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Platform : MonoBehaviour
{
	//Generation of new platforms
	const int maxPlatformNumber = 3;
	public GameObject platform;

	Vector3 newPos;

	void Start(){
		StartCoroutine (ProducePlatforms ());
	}

	public int BuildNewPlatforms(float x, float y, float z){

		newPos.x = x;
		newPos.y = y;
		newPos.z = z;
		platform.transform.position = newPos;
			
		Instantiate (platform, this.transform);
		return 0;
	}
/* THIS IS USELESS
	public Vector3 FindNewPlatformCoord(){
		Vector3 coord = new Vector3 ();

		coord.x += 3;
		coord.y += 5;
		coord.z += 5;

		return coord;
	*/


	IEnumerator ProducePlatforms(){
		Vector3 crd = new Vector3 ();
		while (true) {
			//crd = FindNewPlatformCoord ();
			crd.x += Random.Range(-4,4);
			crd.y += 3;
			crd.z += Random.Range (-2, 2);

			BuildNewPlatforms (crd.x, crd.y, crd.z);

			yield return new WaitForSeconds (1f);
		}
	}
}
