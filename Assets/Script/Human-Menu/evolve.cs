using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evolve : MonoBehaviour
{
    public static string selectedParameter;

    public void onClick(){
        if(selectedParameter == "speaking"){
            evolutions.i_speaking = true;
            Debug.Log("speaking = " + evolutions.i_speaking );
        }
    }
    
}
