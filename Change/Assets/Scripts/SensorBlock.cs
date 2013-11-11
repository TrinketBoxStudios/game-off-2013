using UnityEngine;
using System.Collections;

public class SensorBlock : MonoBehaviour {
	
	public GameObject targetObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider other )
	{
		if(other.tag != "Collectible")
		{
			targetObject.SendMessage("SensorTriggered");
		}
	}
	
	void OnTriggerExit( Collider other )
	{
		if(other.tag != "Collectible")
		{
			targetObject.SendMessage("SensorUnTriggered");
		}
	}
}
