using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 4);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
