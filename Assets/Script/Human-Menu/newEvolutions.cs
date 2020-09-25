using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEvolutions : MonoBehaviour
{
    
    public static GameObject biped ;
    public static GameObject mute ;

    public static GameObject Danger;
    public static GameObject Power;
    public static GameObject Vision;
    public static GameObject Analyze;
    public static GameObject Forest;
    public static GameObject Running;
    public static GameObject Swimming;
    public static GameObject Endurance;
    public static GameObject Imunity;
    public static GameObject Regeneration;

    void Start(){
        biped = GameObject.Find("Biped-Button");
        mute = GameObject.Find("Mute-Button");
        Danger = GameObject.Find("Danger-Button");
        Power = GameObject.Find("Power-Button");
        Vision = GameObject.Find("Vision-Button");
        Analyze = GameObject.Find("Analyze-Button");
        Forest = GameObject.Find("Forest-Button");
        Running =GameObject.Find("Running-Button");
        Swimming =GameObject.Find("Swimming-Button");
        Endurance = GameObject.Find("Endurance-Button");
        Imunity = GameObject.Find("Imunity-Button");
        Regeneration = GameObject.Find("Regeneration-Button");
        mute.SetActive(false);
        Danger.SetActive(false);
        Power.SetActive(false);
        Vision.SetActive(false);
        Analyze.SetActive(false);
        Forest.SetActive(false);
        Running.SetActive(false);
        Swimming.SetActive(false);
        Endurance.SetActive(false);
        Imunity.SetActive(false);
        Regeneration.SetActive(false);
    }
    public static void biss(){

        mute.SetActive(true);
        Danger.SetActive(true); 
        Power.SetActive(true); 
        Vision.SetActive(true); 
        Running.SetActive(true); 
        Swimming.SetActive(true);   

    }
    public static void Pow(){

        Analyze.SetActive(true);


    }
    public static void Vis(){

        Analyze.SetActive(true);
        Forest.SetActive(true);

    }

    public static void Run(){

        Endurance.SetActive(true);

    }

    public static void End(){

        Imunity.SetActive(true);
        Regeneration.SetActive(true);

    }


}
