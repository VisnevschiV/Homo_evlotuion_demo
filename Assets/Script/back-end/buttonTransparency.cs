using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonTransparency : MonoBehaviour
{
    
 private void OnEnable(){   
    if (!gameObject.GetComponent<Image>())
    {
           Debug.Log("fuck , no image");

    }else{
        gameObject.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.00001f;
    }
 }
}
