using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public float flapForce = 20f;
    public bool birdIsAlive = true; // Variable to track if the bird is alive
    public float destroyPositionUp = 13; // Position at which the bird will be destroyed
    public float destroyPositionDown = -14;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        { 
        myRigidBody.linearVelocity = Vector2.up * flapForce;
    }
        if (transform.position.y <= destroyPositionDown || transform.position.y>=destroyPositionUp)
        {  birdIsAlive= false;
           logic.GameOver(); // Call the GameOver method from LogicScript when the bird is destroyed
            if(transform.position.y<=-18){ Destroy(gameObject); } // Destroy the bird if it falls below a certain position
        }
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver(); // Call the GameOver method from LogicScript when the bird collides with something
        birdIsAlive = false; // Set birdIsAlive to false when the bird collides
    }
}

