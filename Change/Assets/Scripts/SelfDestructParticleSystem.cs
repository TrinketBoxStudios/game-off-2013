using UnityEngine;
using System.Collections;

public class SelfDestructParticleSystem : MonoBehaviour 
{
	private ParticleSystem _pSystem;
	// Use this for initialization
	void Start () 
	{
		_pSystem = GetComponent<ParticleSystem>();
		
		if(_pSystem.loop == false)
		{
			Destroy(gameObject, _pSystem.duration);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
