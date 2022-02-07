using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    [Tooltip("The player movement speed.")]
    public float speed;

    private float direction = 1;
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement = new Vector2(1, 0) * speed * direction;

        rb2D.velocity = movement;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction *= -1;
        }
    }
}
