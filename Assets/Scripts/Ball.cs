using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed = 200.0f;

	private Rigidbody2D _rigidbody;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		ResetPosition();
		AddStartingForce();
	}


	public void ResetPosition()
	{
		_rigidbody.position = Vector3.zero;
		_rigidbody.velocity = Vector3.zero;

	}

	public void AddStartingForce()
	{ //Coinflip Logic if < .5 then goes left if less than then right
		float x = Random.value < 0.5f ? -1.0f : 1.0f;
		float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
										Random.Range(.5f, 1.0f);

		Vector2 direction = new Vector2(x, y);
		_rigidbody.AddForce(direction * this.speed);
	}

	public void AddForce(Vector2 force)
	{
		_rigidbody.AddForce(force);
	}

	
	
}
