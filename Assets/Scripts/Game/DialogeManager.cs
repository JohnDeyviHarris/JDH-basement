using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogeText;
    [SerializeField] private List<string> Replics;
    [SerializeField] private float delay;
    [SerializeField] private AudioSource dialogMpThree;
    [SerializeField] private GameObject DialogeWindow;
    private bool skip = false;
    private IEnumerator Playtext()
    {   
        DialogeWindow.SetActive(true);
        foreach (var replic in Replics)
        {
            DialogeText.text = string.Empty;
            foreach (var bukva in replic)
            {
                DialogeText.text += bukva;
                dialogMpThree.Play();
                yield return new WaitForSeconds(0.1f);
                if (skip) break;
            }   
            if (skip) skip = false;
            else yield return new WaitForSeconds(delay);
        }
        DialogeWindow?.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Z)) skip = true;
    }
    public void DialogeStart()
    {
        StartCoroutine(Playtext());
    }
}
