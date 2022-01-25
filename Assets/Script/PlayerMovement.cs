using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRend;
    SpriteRenderer crownSpriteRend;
    Animator playerAnimator;
    public GameObject crown;
    public float playerSpeed;
    float baseSpeedConstant;
    Animator crownAnimator;
    AudioSource footStep;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
        crownSpriteRend = gameObject.transform.Find("Crown").GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
        crownAnimator = crown.GetComponent<Animator>();
        footStep = GetComponent<AudioSource>();
        playerSpeed *= 100;
        baseSpeedConstant = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        float input = Input.GetAxis("Horizontal");
        if(input > 0.1)
        {
            playerAnimator.SetFloat("Speed", Mathf.Abs(input));
            crownAnimator.SetFloat("Speed", Mathf.Abs(input));
            spriteRend.flipX = false;
            crownSpriteRend.flipX = true;
        }else if(input < -0.1)
        {
            crownAnimator.SetFloat("Speed", Mathf.Abs(input));
            playerAnimator.SetFloat("Speed", Mathf.Abs(input));
            spriteRend.flipX = true;
            crownSpriteRend.flipX = false;
        }
        else
        {
            playerAnimator.SetFloat("Speed", 0f);
            crownAnimator.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed *= 2f;
            playerAnimator.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("IsRunning", false);
            playerSpeed = baseSpeedConstant;
        }

        rb.velocity = new Vector2(input*playerSpeed*Time.deltaTime,0);
    }
    public void PlayFootStepSFX()
    {
        footStep.pitch = Random.Range(0.5f,1.5f);
        footStep.Play();
    }
}
