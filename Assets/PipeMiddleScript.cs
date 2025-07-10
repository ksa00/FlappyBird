using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{public LogicScript logicScript; // Reference to LogicScript
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      logicScript=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logicScript == null)
        {
            Debug.LogError("LogicScript not found! Make sure the LogicScript is attached to an object with the tag 'Logic'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3) { 
        logicScript.AddScore(1); // Call the AddScore method from LogicScript
    }
    }
}
