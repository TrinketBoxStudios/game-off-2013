using UnityEngine;
using System.Collections;

public class ConstantMovingCharacterController : MonoBehaviour 
{
	public float direction = 0;

	private bool grounded = false;			// Whether or not the player is grounded.
	private bool jump = false;
	
	public float moveForce;
	public float jumpForce;

	public float maxSpeed;

	public Transform groundCheck;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  
		
		// If the jump button is pressed and the player is grounded then the player should jump.
		if(Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if(direction * rigidbody2D.velocity.x < maxSpeed)
		{
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * direction * moveForce);
		}
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
		{
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		}

		// If the player should jump...
		if(jump)
		{			
			// Add a vertical force to the player.
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			
			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		if(other.tag == "ReverseObject")
		{
			direction *= -1;
		}
	}
}
