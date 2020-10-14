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
    public static GameObject House;
    public static GameObject Protect;
    public static GameObject Team;
    public static GameObject Nr;
    public static GameObject Hierarhy;
    public static GameObject Tactics;
    public static GameObject Religion;
    public static GameObject Stone;
    public static GameObject Stick;
    public static GameObject Fire;
    public static GameObject Axe;
    public static GameObject Food;
    public static GameObject Speaking;
    public static GameObject FootPrint;
    public static GameObject creativity;

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
        House = GameObject.Find("House-Button");
        Protect = GameObject.Find("Protection-Button");
        Team = GameObject.Find("TeamFight-Button");
        Nr = GameObject.Find("Numbers-Button");
        Hierarhy = GameObject.Find("Hierarchy-Button");
        Tactics = GameObject.Find("Tactics-Button");
        Religion = GameObject.Find("Religion-Button");
        Stone = GameObject.Find("Stone-Button");
        Stick = GameObject.Find("Stick-Button");
        Fire = GameObject.Find("Fire-Button");
        Axe = GameObject.Find("Axe-Button");
        Food = GameObject.Find("Food-Button");
        Speaking = GameObject.Find("Speaking-Button");
        FootPrint = GameObject.Find("FootPrints-Button");
        creativity = GameObject.Find("creativity-Button");
        /*mute.SetActive(false);
        Danger.SetActive(false);
        Power.SetActive(false);
        Vision.SetActive(false);
        Analyze.SetActive(false);
        Forest.SetActive(false);
        Running.SetActive(false);
        Swimming.SetActive(false);
        Endurance.SetActive(false);
        Imunity.SetActive(false);
        Regeneration.SetActive(false);*/
        House.SetActive(false);
        Protect.SetActive(false);
        Team.SetActive(false);
        Nr.SetActive(false);
        Hierarhy.SetActive(false);
        Tactics.SetActive(false);
        Religion.SetActive(false);
        Stone.SetActive(false);
        Stick.SetActive(false);
        Fire.SetActive(false);
        Axe.SetActive(false);
        Food.SetActive(false);
        Speaking.SetActive(false);
        FootPrint.SetActive(false);
        Debug.Log(Fire);
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

    public static void brain(){
        Speaking.SetActive(true);
        Stone.SetActive(true);
        Stick.SetActive(true);
        FootPrint.SetActive(true);
        Nr.SetActive(true);
        Team.SetActive(true);
    } 
    public static void crowd_control(){
        Hierarhy.SetActive(true);
        Tactics.SetActive(true);
        Protect.SetActive(true);
    }
    public static void protector(){
        House.SetActive(true);
    } 
    public static void speak(){
        Religion.SetActive(true);
    }
    public static void stones(){
        Fire.SetActive(true);
        Axe.SetActive(true);
    }
    public static void hot(){
        Food.SetActive(true);
    }
}
