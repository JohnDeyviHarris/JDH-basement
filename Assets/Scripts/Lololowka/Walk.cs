using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private bool start = false;
    [SerializeField] private AudioSource MainSong;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Vector2 velocity = Vector2.zero;
        velocity.y = Input.GetAxis("Vertical") * speed;
        velocity.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = velocity;
        if (start == false && rb.velocity != Vector2.zero)
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.z = 0;
            start = true;
            transform.rotation = Quaternion.Euler(rotate);
            MainSong.Play();
        }
    }
}
