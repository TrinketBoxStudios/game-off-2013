using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour 
{
	public float movementSpeed;
	public float jumpHeight;
	
	private Vector3 _playerVelocity;
	
	private Rigidbody _rigidbody;
	
	private bool _grounded = true;
	
	// Use this for initialization
	void Start () 
	{
		_rigidbody = rigidbody;
	}
	
	// Update is called once per frame
	void Update () 
	{
		_playerVelocity = _rigidbody.velocity;
		
		if(Input.GetKeyDown(KeyCode.Space) && _grounded )
		{
			_playerVelocity.y += jumpHeight;
			_grounded = false;
		}
		
		_playerVelocity.x = movementSpeed;
		
		_rigidbody.velocity = _playerVelocity;
	}
	
	void OnCollisionEnter( Collision collision )
	{
		//foreach( ContactPoint contact in collision.contacts)
		//{
			//if(contact.normal == Vector3.up || contact.normal == Vector3.down)
			//{
				_grounded = true;
			//}
		//}
	}
}
