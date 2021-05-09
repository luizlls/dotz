using System;
using UnityEngine;

[System.Serializable]
public enum Direction
{
    Left, Right
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Projectile : MonoBehaviour
{

    [SerializeField]
    float movementSpeed = 2.5f;

    public Direction Direction
    {
        set
        {
            direction = value;
            Flip();
        }

        get => direction;
    }

    private Direction direction;

    private Rigidbody2D body;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        var movementDirection = (direction == Direction.Left)
                ? Vector2.left
                : Vector2.right;

        body.velocity = movementSpeed * movementDirection;
    }

    void Flip()
    {
        GetComponent<SpriteRenderer>().flipX = (direction == Direction.Left);
    }

    public void IncreaseSpeed(float modifier)
    {
        movementSpeed += modifier;
    }
}
