using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private bool start = false;
    private bool isLay = false;
    [SerializeField] private bool layonstart;
    [SerializeField] private AudioSource MainSong;

    public event Action Moved;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (layonstart)
        {
            LieDown();
        }
    }
    private void FixedUpdate()
    {
        Vector2 velocity = Vector2.zero;
        velocity.y = Input.GetAxisRaw("Vertical") * speed;
        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        if (!isLay) rb.velocity = velocity;
        if (velocity != Vector2.zero) Moved?.Invoke();
        if (Input.GetKey(KeyCode.Z))
        {
            LieDown();
        }
    }
    public void LieDown()
    {
        if (isLay) return;
        rb.velocity = Vector2.zero;
        transform.rotation = Quaternion.Euler(0, 0, 90);
        MainSong.Stop();
        Moved += StandUp;
        isLay = true;
    }
    public void StandUp()
    {
        if (!isLay) return;
        transform.rotation = Quaternion.identity;
        MainSong.Play();
        Moved -= StandUp;
        isLay = false;
    }
}
