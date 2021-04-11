using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    //TODO create state machine
    //TODO enemy ai should be able to jump through platforms
    public Transform target;
    public float speed = 80f;
    public float nextWayPointDistance = 3f;
    public Transform gfx;
    public float gravityForceScale = 5f;

    private Path path;
    private int currentWayPoint = 0;
    private bool reachedEndOfPath = false;
    private Seeker seeker;
    private Rigidbody2D rb;

    private void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, 0.5f);
    }

    private void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    private void OnPathComplete(Path path)
    {
        if (!path.error)
        {
            this.path = path;
            currentWayPoint = 0;
        }
    }

    private void FixedUpdate()
    {
        IgnorePlatformCollisions();
        if (path == null)
        {
            return;
        }

        if (currentWayPoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 dir = ((Vector2)path.vectorPath[currentWayPoint] - rb.position);
        Vector2 force = dir * speed * Time.deltaTime;
        force = new Vector2(force.x, force.y * gravityForceScale);
        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]);

        if (distance < nextWayPointDistance)
        {
            currentWayPoint++;
        }

        if (force.x >= 0.01f)
        {
            gfx.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (force.x <= -0.01f)
        {
            gfx.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    private void IgnorePlatformCollisions()
    {
        if (this.rb.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(10, 12, true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(10, 12, false);
        }
    }
}
