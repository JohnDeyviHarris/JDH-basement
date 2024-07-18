using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TerminalInput : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField;
    private Animator animator;
    [SerializeField] private ComputerTerminal ComputerTerminal;
    private void Awake()
    {
        InputField = GetComponent<TMP_InputField>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            InputField.text = string.Empty;
            if (InputField.text == "JDCheat.activate")
            {
                print("JDCheat activated!");
            }
            if (InputField.text == "dir/s")
            {
                StartCoroutine(jopadirs());
            }
            InputField.text = string.Empty;
        }
    }
    private IEnumerator jopadirs()
    {
        print("попа жопа антилопа");
        ComputerTerminal.canexit = false;
        animator.enabled = true;
        animator.SetBool("dirs", true);
        yield return new WaitForSeconds(20);
        animator.SetBool("dirs", false);
        animator.enabled = false;
        ComputerTerminal.canexit = true;
    }
}
