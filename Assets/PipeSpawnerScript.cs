using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab; // The pipe prefab to spawn
    public float spawnInterval = 2.0f; // Time interval between spawns
    private float timer = 0f; // Timer to track spawn intervals
    public float heightOffset = 10.0f; // Offset for the pipe height
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe(); // Spawn the first pipe immediately
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime; // Increment the timer
            return; // Exit if the interval has not yet passed
        }
        else { 
           spawnPipe(); // Spawn a pipe
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset; // Calculate the lowest point for the pipe
        float highestPoint = transform.position.y + heightOffset; // Calculate the highest point for the pipe
        // Instantiate a new pipe at the spawner's position and rotation
        Instantiate(pipePrefab,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }

}
