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
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if  (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
