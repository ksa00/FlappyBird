using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyPositionX = -30; // Position at which the pipe will be destroyed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position+(Vector3.left*moveSpeed * Time.deltaTime);
        if (transform.position.x < destroyPositionX)
        {
            Debug.Log("Pipe destroyed at position: " + transform.position.x);
            Destroy(gameObject); // Destroy the pipe if it moves past the destroy position
        }
    }
}
