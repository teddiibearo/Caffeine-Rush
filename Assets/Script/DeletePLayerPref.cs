using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePLayerPref : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
