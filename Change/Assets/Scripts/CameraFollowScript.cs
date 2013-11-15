using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

	public GameObject followTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 newPos = followTarget.transform.position;

		newPos.z = transform.position.z;

		transform.position = newPos;
	}
}
