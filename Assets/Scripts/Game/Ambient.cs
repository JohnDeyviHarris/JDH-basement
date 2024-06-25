using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ambient : MonoBehaviour
{
    public UnityEvent AmbientStart;
    public UnityEvent AmbientEnd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AmbientStart.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AmbientEnd.Invoke();
        }
    }
}