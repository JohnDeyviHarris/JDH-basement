using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ambient : MonoBehaviour
{
    public UnityEvent AmbientStart;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AmbientStart.Invoke();
        }
    }
}

public class JDHOMPEvent : UnityEvent<Animator, BoxCollider2D>
{

}