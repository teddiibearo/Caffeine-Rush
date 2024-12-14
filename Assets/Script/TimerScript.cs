using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class Timer : MonoBehaviour
{
    float remainingtime;
    public float Remainingtime { get { return remainingtime; } set { remainingtime = value; } }
    [SerializeField] bool doubledrain;
    public bool Doubledrain { get { return doubledrain; } set { doubledrain = value; } }
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        remainingtime = 10.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingtime > 0)
        {
            if(doubledrain == true)
            {
                remainingtime -= 2 * Time.deltaTime;
            }
            else
            {
                remainingtime -= Time.deltaTime;
            }
            
        }
        else if (remainingtime < 0)
        {
            remainingtime = 0;
        }


        slider.value = remainingtime;
        Debug.Log(remainingtime);

        float second = remainingtime % 60;
        /*if(doubledrain == true )
        {
            timertext.color = UnityEngine.Color.red;
        }
        else
        {
            timertext.color= UnityEngine.Color.white;
        }*/

    }
}
