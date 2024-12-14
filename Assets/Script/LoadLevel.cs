using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] public int LevelBuildNum;
    public void OpenLevel()
    {
        SceneManager.LoadScene(LevelBuildNum);
    }
}
