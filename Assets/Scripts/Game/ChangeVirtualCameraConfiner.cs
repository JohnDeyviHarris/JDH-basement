using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVirtualCameraConfiner : MonoBehaviour
{
    [SerializeField] private CinemachineConfiner2D cinconf;
    [SerializeField] private Collider2D confiner;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        cinconf.m_BoundingShape2D = confiner;
    }
}
