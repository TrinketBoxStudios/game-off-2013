using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour 
{
	public float movementSpeed;
	public float jumpHeight;
	
	private Vector3 _playerVelocity;
	
	private Rigidbody _rigidbody;
	
	// Use this for initialization
	void Start () 
	{
		_rigidbody = rigidbody;
	}
	
	// Update is called once per frame
	void Update () 
	{
		_playerVelocity = _rigidbody.velocity;
		
		if(Input.GetKeyDown(KeyCode.Space) )
		{
			_playerVelocity.y += jumpHeight;	
		}
		
		_playerVelocity.x = movementSpeed;
		
		_rigidbody.velocity = _playerVelocity;
	}
}
