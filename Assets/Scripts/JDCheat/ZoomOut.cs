using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZoomOut : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera VirtCamera;
    [SerializeField] private TextMeshProUGUI valuetxt;
    private Slider slider;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void OnValueChanged()
    {
        valuetxt.text = MathF.Round(slider.value, 2).ToString();
        VirtCamera.m_Lens.OrthographicSize = slider.value;
    }
}
