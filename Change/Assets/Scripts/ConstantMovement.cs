using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour 
{
	public float movementSpeed;
	public float jumpHeight;
	
	private Vector3 _playerVelocity;
	
	private Vector3 _prevPosition;
	
	private Rigidbody _rigidbody;
	
	private bool _grounded = true;
	
	private bool _blocked = false;
	
	// Use this for initialization
	void Start () 
	{
		_rigidbody = rigidbody;
		_prevPosition = transform.position;
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
		
		if(!_blocked)
		{
			_playerVelocity.x = movementSpeed;
		}
		
		_rigidbody.velocity = _playerVelocity;
	}
	
	void SensorTriggered()
	{
		_blocked = true;	
	}
	
	void SensorUnTriggered()
	{
		_blocked = false;
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
	
	void OnTriggerEnter( Collider other )
	{
		other.SendMessage("Collected", SendMessageOptions.DontRequireReceiver);
	}
}
