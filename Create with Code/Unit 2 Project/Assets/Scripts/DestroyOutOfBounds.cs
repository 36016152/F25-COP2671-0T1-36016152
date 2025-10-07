using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    [SerializeField] 
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;


    // Update is called once per frame
    void Update()
    {
        //If an object leave the player's view, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if  (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
