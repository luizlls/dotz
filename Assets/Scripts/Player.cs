using UnityEngine;

enum PlayerState
{
    Alive, Dead
}

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    GameEvent playerDeathEvent;

    [SerializeField]
    Sprite alive;

    [SerializeField]
    Sprite dead;

    [SerializeField]
    float jumpForce = 5f;

    [SerializeField]
    float jumpFallMultiplier = 2.5f;

    [SerializeField]
    float lowJumpMultiplier  = 2f;

    [SerializeField]
    string[] dangerousLayers = new string[] { };

    private PlayerState state = PlayerState.Alive;

    private Rigidbody2D body;

    void Awake()
    {
        state = PlayerState.Alive;
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (state != PlayerState.Alive)
            return;

        if (Input.GetMouseButtonDown(0) && body.velocity.y <= 0) {
            Jump();
        }

        if (body.velocity.y < 0) {
            SmoothMotion(jumpFallMultiplier);
        } else if (body.velocity.y > 0 && !Input.GetMouseButton(0)) {
            SmoothMotion(lowJumpMultiplier);
        }
    }

    void Jump()
    {
        body.velocity = Vector2.up * jumpForce;
    }

    void SmoothMotion(float multiplier)
    {
        body.velocity += Vector2.up * Physics2D.gravity.y * (multiplier - 1) * Time.deltaTime;
    }

    void Die(bool shouldJump)
    {
        playerDeathEvent.Raise();

        state = PlayerState.Dead;

        if (shouldJump) {
            Jump();
        }

        GetComponent<SpriteRenderer>().sprite = dead;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (var layer in dangerousLayers)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer(layer)) {
                Die(shouldJump: layer == "Ground");
            }
        }
    }

    public bool IsAlive() => state != PlayerState.Dead;
}

