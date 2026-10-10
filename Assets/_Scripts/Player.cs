using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpSpeed = 30f;
    [SerializeField] float groundCheckRadius = 0.2f;


    [SerializeField] float xInput;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator ani;
    [SerializeField] Transform groundCheck; 
    [SerializeField] LayerMask groundLayer;

    bool isFacingRight = true;
    bool isGrounded;

    
   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }


    private void Update()
    {

        xInput = Input.GetAxisRaw("Horizontal");
        if (xInput != 0)
        {
            ani.SetBool("isRun", true);
        }
        else ani.SetBool("isRun", false);
        Flip();

    }
    
    private void FixedUpdate()
    {
        Movement();
        CheckGround();
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) Jump();
        
    }
    void Movement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed * Time.fixedDeltaTime, rb.linearVelocity.y);
    }
    void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpSpeed * Time.fixedDeltaTime;
    }
    void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }
    void Flip()
    {
        if (xInput > 0 && !isFacingRight)
        {
            isFacingRight = true;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (xInput < 0 && isFacingRight)
        {
            isFacingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coins")
        {
            col.tag = "Untagged";
            Debug.Log("detect coins");
            Destroy(col.gameObject);
            UIManager.Ins.updateCoins();
        }

    }
    private void OnDrawGizmos() {
        if (groundCheck == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        
    }
    
}
