using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UI_animator : MonoBehaviour
{
    public GameObject info;
    public GameObject list;

   public void onClick()
    {
       info.SetActive(true); 
       LeanTween.scale(info , new Vector3(1f,1f,8), 1);
       LeanTween.scale(list, new Vector3(0.9f,0.9f,4),1);

    }
    public void bckClick()
    {
        LeanTween.scale(info, new Vector3(0f,0f,8), 1);
        LeanTween.scale(list, new Vector3(1.28f,1.28f,4),1);

    }
}
