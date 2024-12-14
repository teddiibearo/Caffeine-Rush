using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class startlevel : MonoBehaviour
{
    public GameObject text;

    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Time.timeScale = 1;
            text.gameObject.SetActive(false);
        }
    }

}
