using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {           
                Destroy(this.gameObject);
                Destroy(door);
                AudioManager.instance.PlaySfx("DoorOpen");

        }
    }
}
