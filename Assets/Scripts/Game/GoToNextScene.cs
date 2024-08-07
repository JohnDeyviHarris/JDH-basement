using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
    [NaughtyAttributes.Scene] [SerializeField] private string SceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneName);
        } 
    }
    public void ChangeOFScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
