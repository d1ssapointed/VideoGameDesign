using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Transform player;
	[SerializeField] public float moveSpeed;
	
	float vertical, horizontal;
	
	Rigidbody2D myRigidbody2D;
	public float q = .707f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    	myRigidbody2D = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        move();
		vertical = 0f;
		horizontal = 0f;
    }
	
	void move()
	{
		if (Input.GetKey(KeyCode.A)) {
			horizontal = -1f;
		}
		else if (Input.GetKey(KeyCode.D)) {
			horizontal = 1f;
		}
		if (Input.GetKey(KeyCode.S)) {
			vertical = -1f;
		}
		else if (Input.GetKey(KeyCode.W)) {
			vertical = 1f;
		}
		if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) {
			horizontal = -q;
			vertical = q;
		}
		else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) {
			horizontal = q;
			vertical = q;
		}
		else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) {
			horizontal = -q;
			vertical = -q;
		}
		else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) {
			horizontal = q;
			vertical = -q;
		}
		
		
		
		myRigidbody2D.linearVelocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
	}
}
