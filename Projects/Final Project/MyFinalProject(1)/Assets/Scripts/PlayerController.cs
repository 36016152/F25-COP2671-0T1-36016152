using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    //Initialize variables
    private float hInput;
    private float vInput;
    public float speed = 10.0f;
    private Animator playerAnim;

    // Update is called once per frame
    void Update()
    {
        // Grab input data
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        // Translate player in direction of user input
        transform.Translate(Vector2.right * hInput * Time.deltaTime * speed);
        transform.Translate(Vector2.up * vInput * Time.deltaTime * speed);



    }
}
