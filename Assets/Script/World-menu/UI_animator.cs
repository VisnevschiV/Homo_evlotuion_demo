using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UI_animator : MonoBehaviour
{
    private static int lvl;
    public GameObject info;
    public GameObject list;
    public   GameObject where;
    public static GameObject look;
    public static GameObject Fstyle;

    public static GameObject who;

    public static GameObject Story;

    public Sprite img;
    public Button place;

   public void onClick()
    {
        place.image.sprite = img;
        info.SetActive(true); 
        LeanTween.scale(info , new Vector3(1f,1f,8), 1);
        LeanTween.scale(list, new Vector3(0.9f,0.9f,4),1);
        look = GameObject.Find("look");
        Fstyle = GameObject.Find("fight");
        Story = GameObject.Find("info");
        who = GameObject.Find("who");
        lvl = 0;        
        

    }
    public void bckClick()
    {
        if(lvl ==0){
            LeanTween.scale(info, new Vector3(0f,0f,8), 1);
            LeanTween.scale(list, new Vector3(1.28f,1.28f,4),1);
        }else if(lvl == 1){
            // atent ca Lean Tween are pozitii diferite de unity
            
        }
    }
    public void map()
    {

        Animator animator = info.GetComponent<Animator>();
        bool map = animator.GetBool("map");
        animator.SetBool("map", !map);

    }
    public void eye()
    {

        Animator animator = info.GetComponent<Animator>();
        bool eyez = animator.GetBool("eye");
        animator.SetBool("eye", !eyez);


    }

    public void fightF()
    {

        Animator animator = info.GetComponent<Animator>();
        bool Fight = animator.GetBool("fight");
        animator.SetBool("fight", !Fight);

    }

    public void infoF()
    {

        Animator animator = info.GetComponent<Animator>();
        bool inf = animator.GetBool("inf");
        animator.SetBool("inf", !inf);

    }
}
