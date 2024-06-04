using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    [SerializeField] private GameObject PlayerSprite;
    private SpriteRenderer PlayerSpriteRenderer;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        PlayerSpriteRenderer = PlayerSprite.GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        bool walk = rb.velocity == Vector2.zero;
        if (!walk)
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Idle", false);
        }
        if (walk)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerSpriteRenderer.flipX = true;
        }
        if(Input.GetKey(KeyCode.D))
        {
            PlayerSpriteRenderer.flipX = false;
        }
    }
}
