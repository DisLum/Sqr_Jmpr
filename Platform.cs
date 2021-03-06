using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Platform : MonoBehaviour
{
	//Generation of new platforms
	const int maxPlatformNumber = 3;
	public GameObject platform;

	int place;

	Vector3 newPos;

	void Start(){
		/*Vector3 crd = new Vector3 ();

		crd = FindNewPlatformCoord ();

		BuildNewPlatforms (crd.x,crd.y,crd.z);*/

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

	IEnumerator ProducePlatforms(){
		Vector3 crd = new Vector3 ();
		while (true) {
			place = Random.Range (-2, 2);
			switch (place) {
			case -2:
				crd.x = -2;
				crd.y += 3;
				crd.z = -2;
				break;
			case -1:
				crd.x = -1;
				crd.y += 3;
				crd.z = -1;
				break;
			case 0:
				crd.x = 0;
				crd.y += 3;
				crd.z = 0;
				break;
			case 1:
				crd.x = 1;
				crd.y += 3;
				crd.z = 1;
				break;
			case 2:
				crd.x = 2;
				crd.y += 3;
				crd.z = 2;
				break;
			}
				
			BuildNewPlatforms (crd.x, crd.y, crd.z);

			yield return new WaitForSeconds (1f);
		}
	}
}
