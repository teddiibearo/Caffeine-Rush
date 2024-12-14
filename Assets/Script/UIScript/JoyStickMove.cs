using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickMove : MonoBehaviour
{
    public Joystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    [SerializeField] bool issliding;
    public bool Issliding { get { return issliding; } set { issliding = value; } }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (issliding == false)
        {
            if (movementJoystick.Direction.y != 0)
            {
                rb.velocity = new Vector2(movementJoystick.Direction.x * playerSpeed, movementJoystick.Direction.y * playerSpeed);

            }
            else
            {
                rb.velocity = Vector2.zero;
 
            }
        }
    }
}
