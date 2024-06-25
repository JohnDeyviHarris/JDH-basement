using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] private List<Transform> Poses;
    private int todayPos = 1;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float distance = (Poses[todayPos].position - transform.position).magnitude;
        if (distance < 0.5f)
        {
            todayPos += 1;
            if (todayPos == Poses.Count) todayPos = 0;
        }
        Vector2 TudaNamNado = Poses[todayPos].position - transform.position;
        Vector2 velocity = TudaNamNado.normalized;
        rb.velocity = velocity;
    }
}
