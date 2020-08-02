using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restriction: MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
    }
}
