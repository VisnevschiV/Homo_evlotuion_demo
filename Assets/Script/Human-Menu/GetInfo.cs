using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfo : MonoBehaviour
{
    public GameObject info;
    public GameObject evolve_button;
    public string parameter;
    GameObject[] all;

    // Update is called once per frame
    public void onClick()
    {
        all = GameObject.FindGameObjectsWithTag("text");
        foreach (GameObject t in all)
        {
            t.SetActive(false);
        }
        evolve_button.SetActive(true);
        info.SetActive(true);
        if(sceneManagment.scenenr == 4){
              switch (this.name)
              {
              
              case "Biped-Button":
                     evolve.selectedParameter = 1;
                     Debug.Log("naaah");
              break;
              
              case "Mute-Button":
                     evolve.selectedParameter = 2;
              break;

              case "Danger-Button":
                     evolve.selectedParameter = 3;
              break;

              case "Power-Button":
                     evolve.selectedParameter = 4;
              break;

              case "Vision-Button":
                     evolve.selectedParameter = 5;
              break;

              case "Analyze-Button":
                     evolve.selectedParameter = 6;
              break;

              case "Forest-Button":
                     evolve.selectedParameter = 7;
              break;

              case "Running-Button":
                     evolve.selectedParameter = 8;
              break;

              case "Swimming-Button":
                     evolve.selectedParameter = 9;
              break;

              case "Endurance-Button":
                     evolve.selectedParameter = 10;
              break;

              case "Imunity-Button":
                     evolve.selectedParameter = 11;
              break;

              case "Regeneration-Button":
                     evolve.selectedParameter = 12;
              break;
              
              };
        }else if(sceneManagment.scenenr == 3){
               
        }       
        
    }

}
