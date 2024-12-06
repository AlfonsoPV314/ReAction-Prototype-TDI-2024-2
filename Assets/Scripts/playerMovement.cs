using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float Move;

    public float speed;

    public float jump;

    // public Vector2 boxSize;
    
    // public float castDistance;

    bool grounded = false;

    // public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(Move * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && grounded){

            rb.AddForce(new Vector2(rb.linearVelocity.x, jump * 10));
        }
    }

    // public bool isGrounded(){
    //     if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer)){
    //         return true;
    //     }
    //     return false;
    // }

    // private void OnDrawGizmos(){
    //     Gizmos.DrawWireCube(transform.position, boxSize);
    // }

    private void OnCollisionEnter2D(Collision2D other){

        if (other.gameObject.CompareTag("Ground")){
            Vector3 normal = other.GetContact(0).normal;
        if(normal == Vector3.up){
                grounded = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.CompareTag("Ground")){
            grounded = false;
        }
    }
}
