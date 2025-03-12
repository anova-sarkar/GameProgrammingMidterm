using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public Rigidbody2D RB;

    public BoxCollider2D BC;

    public PlayerScript Player;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (transform.position.x < Player.transform.position.x)
        {
            vel.x = speed;
        }

        if (transform.position.x > Player.transform.position.x)
        {
            vel.x = -speed;
        }

        if (transform.position.y < Player.transform.position.y)
        {
            vel.y = speed;
        }

        if (transform.position.y > Player.transform.position.y)
        {
            vel.y = -speed;
        }

        RB.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            BC.isTrigger = true;
            Debug.Log("Pass through wall");
        } else
        {
            BC.isTrigger = false;
        }
    }

}
