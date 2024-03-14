using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleMove : MonoBehaviour
{
    private GameObject role;

    public float speed;
    public BoxCollider2D myBoxCollider;

    [SerializeField]private LayerMask groundLayer;

    //public Animator anim;
    private Rigidbody2D body;
    //private BoxCollider2D boxCollider;

    public float jumpForce;
    //public Transform footPoint;
    private bool isGround = true;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myBoxCollider.size = new Vector2(10, 12);

        float horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded())
        {
            jump();
            Debug.Log("w key was pressed.");
            transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("s key was pressed.");
            myBoxCollider.size = new Vector2(12, 4);
        }

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("d key was pressed.");
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("a key was pressed.");
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }*/
    }

    private void jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        //anim.SetTrigger("jump");
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(myBoxCollider.bounds.center, myBoxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

}
