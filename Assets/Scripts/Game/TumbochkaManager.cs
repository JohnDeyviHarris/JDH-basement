using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbochkaManager : MonoBehaviour
{
    private int tumbochkaCount;
    [SerializeField] private int tumbochkaMax;
    [SerializeField] private GameObject walls;
    [SerializeField] private AudioSource boom;
    public void GetTumbochka()
    {
        tumbochkaCount += 1;
        if (tumbochkaCount == tumbochkaMax)
        {
            print("ÔÓÔ‡‡‡‡‡‡‡");
            walls.SetActive(false);
            boom.Play();
        }
    }
}
