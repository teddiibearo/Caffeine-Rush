using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostGameMenu : MonoBehaviour
{
    public int nextSceneLoad;
    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex+1;
    }
    public void Exitlevel()
    {
        Time.timeScale = 1;
        if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
        SceneManager.LoadScene(2);
    }

    public void NextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex ==17) 
        {
            Debug.Log("end");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);
            if( nextSceneLoad > PlayerPrefs.GetInt("levelAt")){
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
        
    }
}
