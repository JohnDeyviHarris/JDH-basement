using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZonePNG : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Movement movement = collision.GetComponent<Movement>();
            if (movement.ishide != true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }      
        }
    }
}
