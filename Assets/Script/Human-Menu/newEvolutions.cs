using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEvolutions : MonoBehaviour
{
    
    public static GameObject biped ;
    public static GameObject mute ;

    void Start(){
        biped = GameObject.Find("Biped-Button");
        mute = GameObject.Find("Mute-Button");
        mute.SetActive(false);
    }
    void Update(){

        if(evolutions.F_Biped == true){   
            mute.SetActive(true);         
        }

    }
    
}
