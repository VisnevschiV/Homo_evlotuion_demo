using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evolve : MonoBehaviour
{
    public static int selectedParameter;

    public void onClick(){
        switch (selectedParameter)
        {
            
            case 1:
                evolutions.F_Biped = true;
                Debug.Log("evolutions.F_Biped");
                newEvolutions.biss();
            break;

            case 2:
                evolutions.F_Mute = true;
                Debug.Log( evolutions.F_Mute);
            break;

            case 3:
                evolutions.F_Danger = true;
            break;

            case 4:
                evolutions.F_Power = true;
                newEvolutions.Pow();
            break;

            case 5:
                evolutions.F_Vision = true;
                newEvolutions.Vis();
            break;

            case 6:
                evolutions.F_Analyzing = true;
            break;

            case 7:
                evolutions.F_Forest_vison = true;
            break;

            case 8:
                evolutions.F_Running = true;
                newEvolutions.Run();
            break;

            case 9:
                evolutions.F_Swimming = true;
            break;

            case 10:
                evolutions.F_Endurance = true;
                newEvolutions.End();
            break;

            case 11:
                evolutions.F_Imunity = true;
            break;

            case 12:
                evolutions.F_Regeneration = true;
            break;
            case 13:
                
            break;
            case 14:
                evolutions.i_protection = true;
                newEvolutions.protector();
            break;
            case 15:
                evolutions.i_teamfight = true;
                newEvolutions.crowd_control();
            break;
            case 16:
                evolutions.i_numbers = true;
            break;
            case 17:
                evolutions.i_hierarchy = true;
            break;
            case 18:
                evolutions.i_tactics = true;
            break;
            case 19:
                evolutions.i_Religion = true;
            break;
            case 20:
                evolutions.i_Stone = true;
                newEvolutions.stones();
            break;
            case 21:
                evolutions.i_Stick = true;
            break;
            case 22:
                evolutions.i_Fire = true;
                newEvolutions.hot();
            break;
            case 23:
                evolutions.i_Weapons = true;
            break;
            case 24:
                evolutions.i_Food = true;
            break;
            case 25:
                evolutions.i_speaking = true;
                newEvolutions.speak();
            break;
            case 26:
                evolutions.i_footprints = true;
            break;
            case 27:
                evolutions.i_creativity = true;
                newEvolutions.brain();
            break;

            
        }
        
    }
    
}
