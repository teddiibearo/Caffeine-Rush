using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] public float slidespeed;
    [SerializeField] public bool Vertical;
    private float  x, y;
    private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<JoyStickMove>().Issliding = true;
            Debug.Log("no move");
        }


        rb = other.GetComponent<Rigidbody2D>(); 
        x = rb.velocity.x;
        y = rb.velocity.y;
        Debug.Log(x + " , " + y);
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("push stay");
        if (Vertical == false)
        {
            if (x < 0)
                rb.velocity = new Vector2(-slidespeed, 0);
            if (x > 0)
                rb.velocity = new Vector2(slidespeed, 0);
        }
        if(Vertical == true)
        {
            if (y < 0)
                rb.velocity = new Vector2(0, -slidespeed);
            if (y > 0)
                rb.velocity = new Vector2(0, slidespeed);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<JoyStickMove>().Issliding = false;
            Debug.Log("can move");
        }
    }
}
