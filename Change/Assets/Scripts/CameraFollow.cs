using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public GameObject followTarget;
	
	private Vector3 _currentPositon;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		_currentPositon = followTarget.transform.position;
		
		// let the camera keep its z position
		_currentPositon.z = transform.position.z;
		
		transform.position = _currentPositon;
	}
}
