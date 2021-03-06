using UnityEngine;
using System.Collections;

public class CharacterController2D : MonoBehaviour
{
    public McAnimator mcAnimator;
    [SerializeField] private float jumpForce = 400f;                          // Amount of force added when the player jumps.
    [SerializeField] private float dashForceX = 2500f;
    [SerializeField] private float dashForceY = 2000f;
    [SerializeField] private float dashTimer = 1f;
    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;  // How much to smooth out the movement
    [SerializeField] private bool airControl = true;                         // Whether or not a player can steer while jumping;
    [SerializeField] private LayerMask whatIsGround;                          // A mask determining what is ground to the character
    [SerializeField] private Transform groundCheck;                           // A position marking where to check if the player is grounded.
    [SerializeField] private Transform ceilingCheck;                          // A position marking where to check for ceilings
    [SerializeField] private Collider2D crouchDisableCollider;                // A collider that will be disabled when crouching

    const float groundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    const float ceilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
    private bool grounded;            // Whether or not the player is grounded.
    private bool canDash = true;
    private bool dashTimerDone = false;
    private Rigidbody2D rigidb2D;
    private bool facingRight = true;  // For determining which way the player is currently facing.
    private Vector3 velocity = Vector3.zero;

    public bool getFacingRight()
    {
        return facingRight;
    }

    public void AttemptCast()
    {
        mcAnimator.AnimateCast();
    }

    public void AttemptJump()
    {
        if (grounded)
        {
            // Add a vertical force to the player.
            grounded = false;
            rigidb2D.AddForce(new Vector2(0f, jumpForce));
            mcAnimator.AnimateJump();
        }
    }

    public void AttemptDash(float dirX, float dirY)
    {
        if (canDash)
        {
            canDash = false;
            dashTimerDone = false;
            Vector2 dashDir = new Vector2(this.GetDashForce(dirX, dashForceX), this.GetDashForce(dirY, dashForceY));
            //Debug.Log(rigidb2D.velocity);
            //Debug.Log(rigidb2D.angularVelocity);
            Debug.Log(dashDir);
            rigidb2D.AddRelativeForce(dashDir);
            //mcAnimator.AnimateDash();
            StartCoroutine(DashTimer());
        }
    }

    public void Move(float move, bool crouch)
    {
        // If crouching, check to see if the character can stand up
        if (!crouch)
        {
            // If the character has a ceiling preventing them from standing up, keep them crouching
            if (Physics2D.OverlapCircle(ceilingCheck.position, ceilingRadius, whatIsGround))
            {
                crouch = true;
            }
        }

        //only control the player if grounded or airControl is turned on
        if (grounded || airControl)
        {

            // Move the character by finding the target velocity
            Vector3 targetVelocity = new Vector2(move * 10f, rigidb2D.velocity.y);
            // And then smoothing it out and applying it to the character
            rigidb2D.velocity = Vector3.SmoothDamp(rigidb2D.velocity, targetVelocity, ref velocity, movementSmoothing);
            mcAnimator.AnimateMove(Mathf.Abs(rigidb2D.velocity.x));

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !facingRight)
            {
                // ... flip the player.
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && facingRight)
            {
                // ... flip the player.
                Flip();
            }
        }
    }

    public void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    private void Awake()
    {
        rigidb2D = GetComponent<Rigidbody2D>();

        if (transform.localScale.x == -1)
        {
            facingRight = false;
        }
    }

    private void FixedUpdate()
    {
        bool wasGrounded = grounded;
        grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, groundedRadius, whatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                grounded = true;
                if (dashTimerDone) canDash = true;
            }
        }
        this.IgnorePlatformCollisions();
    }

    private IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(dashTimer);
        dashTimerDone = true;
    }

    private float GetDashForce(float dir, float force)
    {
        float dashForce = 0;

        if (dir > 0)
        {
            dashForce = force;
        }
        else if (dir < 0)
        {
            dashForce = force * -1;
        }
        return dashForce;
    }

    private void IgnorePlatformCollisions()
    {
        if (this.rigidb2D.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(10, 11, true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(10, 11, false);
        }
    }
}
