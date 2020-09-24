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
            break;

            case 5:
                evolutions.F_Vision = true;
            break;

            case 6:
                evolutions.F_Analyzing = true;
            break;

            case 7:
                evolutions.F_Forest_vison = true;
            break;

            case 8:
                evolutions.F_Running = true;
            break;

            case 9:
                evolutions.F_Swimming = true;
            break;

            case 10:
                evolutions.F_Endurance = true;
            break;

            case 11:
                evolutions.F_Imunity = true;
            break;

            case 12:
                evolutions.F_Regeneration = true;
            break;
            
        }
        
    }
    
}
