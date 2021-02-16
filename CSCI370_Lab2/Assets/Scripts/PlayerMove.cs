using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody2D body;
    SpriteRenderer sprite;


    private float horz, vert;
    private float moveLimit = 0.7f;

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (horz != 0 && vert != 0)
        {
            horz *= moveLimit;
            vert *= moveLimit;
        }
        
        body.velocity = new Vector2(horz * speed, vert * speed);
        sprite.flipX = body.velocity.x < 0 ? true : false;
    }
}
