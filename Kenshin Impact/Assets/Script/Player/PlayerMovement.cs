using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;

    public Rigidbody2D rigidbody2D;
    public BoxCollider2D collider2D;

    Vector2 direction;
    float horizontal;
    float vertical;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        MovePlayer();
    }

    public void MovePlayer()
    {
        rigidbody2D.velocity = new Vector2(horizontal * 10, vertical * 10);
    }
}
