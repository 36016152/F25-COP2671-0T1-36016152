using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
