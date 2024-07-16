using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Noclip : MonoBehaviour
{
    [SerializeField] private BoxCollider2D BoxCollider2D;
    private Toggle toggle;
    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }
    public void NoclipToggle()
    {
        if (toggle.isOn)
        {
            BoxCollider2D.isTrigger = true;
        }
        else
        {
            BoxCollider2D.isTrigger = false;
        }
    }
}
