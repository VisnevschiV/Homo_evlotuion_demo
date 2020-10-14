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
                newEvolutions.protector();
            break;
            case 15:
                newEvolutions.crowd_control();
            break;
            case 16:
                
            break;
            case 17:
                
            break;
            case 18:
                
            break;
            case 19:
                
            break;
            case 20:
                newEvolutions.stones();
            break;
            case 21:
                
            break;
            case 22:
                newEvolutions.hot();
            break;
            case 23:
                
            break;
            case 24:
                
            break;
            case 25:
                newEvolutions.speak();
            break;
            case 26:
                
            break;
            case 27:
                newEvolutions.brain();
            break;

            
        }
        
    }
    
}
