using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitgame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
