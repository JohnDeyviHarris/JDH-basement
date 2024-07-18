using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComputerTerminal : MonoBehaviour
{
    private Image ComputerImage;
    private Animator Animator;
    [SerializeField] private TextMeshProUGUI consoletext;
    [SerializeField] private Sprite EmptyCompuetSprite;
    public bool canexit = true;
    private void Awake()
    {
        ComputerImage = GetComponent<Image>();
        Animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Animator.enabled = false;
            ComputerImage.sprite = EmptyCompuetSprite;
            Time.timeScale = 0f;
            consoletext.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && canexit)
        {
            Animator.enabled = true;
            Time.timeScale = 1f;
            consoletext.enabled = false;
        }
    }
}
