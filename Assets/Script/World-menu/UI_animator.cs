using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;


public class UI_animator : MonoBehaviour
{
    private static int lvl; // Monitorizeaza unde ne aflam
    public GameObject info; // Itemul Mare ce contine butoanele(Obiectul-Tata)
    public GameObject list; // lista cu animale(ptu animatia de micsorare)
    public   Button where; // butonul cu harta
    public static GameObject look; // butonul cu ochi
    public static GameObject Fstyle; // Butonul cu pumn

    public static GameObject Story; // Butonul cu Lupa

    public Sprite img; //imaginea pentru Who
    public Sprite newMap; // Mapa Cu informatii
    public Button place; //tot who
  

    // Cand fac click pe animal
    public void onClick()
    {
        
        place.image.sprite = img;// schimb imaginea de sus
        info.SetActive(true);   
        LeanTween.scale(info , new Vector3(1f,1f,8), 1);
        LeanTween.scale(list, new Vector3(0.9f,0.9f,4),1);
        look = GameObject.Find("look");//?
        Fstyle = GameObject.Find("fight");//?
        Story = GameObject.Find("info");//?
        lvl = 0;        
        

    }
    // orice nu e buton, bentru a merge iar la world menu
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
        //Animator animator = info.GetComponent<Animator>();
        //bool map = animator.GetBool("map");
       // animator.SetBool("map", !map);
        where.image.sprite = newMap;

    }
    public void eye()
    {

        Animator animator = info.GetComponent<Animator>();
        bool eyez = animator.GetBool("eye");
        animator.SetBool("eye", !eyez);


    }
// F de la Function
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
