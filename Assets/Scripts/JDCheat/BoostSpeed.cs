using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostSpeed : MonoBehaviour
{
    [SerializeField] private Movement Movement;
    private Toggle toggle;
    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public void BoostSpeedToggle()
    {
        if (toggle.isOn)
        {
            Movement.speed = 3;
        }
        else
        {
            Movement.speed = 0.7f;
        }
    }
}
