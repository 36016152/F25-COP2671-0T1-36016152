using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnim = GetComponentInChildren<Animator>();
        playerRenderer = GetComponentInChildren<SpriteRenderer>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    //Initialize variables
    private float hInput;
    private float vInput;
    public float speed = 10.0f;
    private Animator playerAnim;
    private SpriteRenderer playerRenderer;
    private Rigidbody2D playerRB;

    // Update is called once per frame
    void Update()
    {
        // Grab input data
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        // Translate player in direction of user input
        transform.Translate(Vector2.right * hInput * Time.deltaTime * speed);
        transform.Translate(Vector2.up * vInput * Time.deltaTime * speed);

        //Animate player in direction of movement
        if (hInput < 0.0f)
        {
            playerRenderer.flipX = true;
            playerAnim.SetBool("hMove", true);
            playerAnim.SetBool("isMoving", true);
        }
        if (hInput > 0.0f)
        {
            playerRenderer.flipX = false;
            playerAnim.SetBool("hMove", true);
            playerAnim.SetBool("isMoving", true);
        }
        if ( hInput == 0.0f)
        {
            playerRenderer.flipX = false;
            playerAnim.SetBool("hMove", false);
        }

        if (vInput < 0.0f)
        {
            playerAnim.SetFloat("inputY", -1);
            playerAnim.SetBool("isMoving", true);
        }
        if (vInput > 0.0f)
        {
            playerAnim.SetFloat("inputY", 1);
            playerAnim.SetBool("isMoving", true);
        }
        if (vInput == 0.0f)
        {
            playerAnim.SetFloat("inputY", 0);
            playerRenderer.flipX = false;
            playerAnim.SetBool("hMove", false);
        }

        if (vInput == 0 && hInput == 0)
        {
            playerAnim.SetBool("isMoving", false);
        }
    }
}
