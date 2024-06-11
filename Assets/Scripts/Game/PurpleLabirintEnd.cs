using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleLabirintEnd : MonoBehaviour
{
    [SerializeField] private GameObject mainCam;
    [SerializeField] private GameObject secondCam;
    [SerializeField] private GameObject wall;
    [SerializeField] private AudioSource mainsong;
    [SerializeField] private AudioSource c4;
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            mainsong.Stop();
            c4.Play();
            secondCam.SetActive(true);
            mainCam.SetActive(false);  
            yield return new WaitForSeconds(11);
            wall.SetActive(false);
            yield return new WaitForSeconds(2);
            mainsong.Play();
            mainCam.SetActive(true);
            secondCam.SetActive(false);

        }
    }
}
