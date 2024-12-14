using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
 
    [SerializeField] bool holdingHat;
    public bool HoldingHat { get { return holdingHat; } set { holdingHat = value; } }
}
