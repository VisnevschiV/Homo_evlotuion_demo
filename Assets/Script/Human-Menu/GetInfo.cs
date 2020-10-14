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
        if(true){
              switch (this.name)
              {
              
              case "Biped-Button":
                     evolve.selectedParameter = 1;
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
              
             /* };
        }else if(true){
              switch (this.name)
              {*/
              
              case "House-Button":
                     evolve.selectedParameter = 13;
              break;
              case "Protection-Button":
                     evolve.selectedParameter = 14;
              break;
              case "TeamFight-Button":
                     evolve.selectedParameter = 15;
              break;
              case "Numbers-Button":
                     evolve.selectedParameter = 16;
              break;
              case "Hierarchy-Button":
                     evolve.selectedParameter = 17;
              break;
              case "Tactics-Button":
                     evolve.selectedParameter = 18;
              break;
              case "Religion-Button":
                     evolve.selectedParameter = 19;
              break;
              case "Stone-Button":
                     evolve.selectedParameter = 20;
              break;
              case "Stick-Button":
                     evolve.selectedParameter = 21;
              break;
              case "Fire-Button":
                     evolve.selectedParameter = 22;
              break;
              case "Axe-Button":
                     evolve.selectedParameter = 23;
              break;
              case "Food-Button":
                     evolve.selectedParameter = 24;
              break;
              case "Speaking-Button":
                     evolve.selectedParameter = 25;
              break;
              case "FootPrints-Button":
                     evolve.selectedParameter = 26;
              break;
              case "creativity-Button":
                     evolve.selectedParameter = 27;
              break;
              }
        }       
        
    }

}
