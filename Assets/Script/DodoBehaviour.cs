using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodoBehaviour : MonoBehaviour
{
    float count;
    int wholeCount;
    Rigidbody2D rb;
    SpriteRenderer spriteRend;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        count += Time.deltaTime;
        if (count >= 1)
        {
            wholeCount++;
            count = 0;
        }

        if (wholeCount % 4 == 0)
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
            spriteRend.flipX = false;
        }
        else if (wholeCount % 2 == 0)
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
            spriteRend.flipX = true;

        }
    }
}
