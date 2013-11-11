using UnityEngine;
using System.Collections;

public class CoinPickupScript : MonoBehaviour {
	
	public GameObject pickupPSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Collected()
	{
		Instantiate(pickupPSystem, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
