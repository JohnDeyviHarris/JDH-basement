using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ishide = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ishide = false;
        }
    }
}
