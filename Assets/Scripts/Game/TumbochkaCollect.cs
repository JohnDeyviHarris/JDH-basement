using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbochkaCollect : MonoBehaviour
{
    [SerializeField] private TumbochkaManager manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.GetTumbochka();
            Destroy(gameObject);
        }
    }
}
