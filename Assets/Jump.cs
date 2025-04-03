using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }
    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
