using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagment : MonoBehaviour
{
    public  GameObject Human;
    public  GameObject Game;
    public  GameObject World;
    public  GameObject Intelectual;
    public  GameObject phisical;

    public static int scenenr;
   public void WorldMenu(){
       scenenr = 1;
       Time.timeScale = 0;
      Game.SetActive(false);
       World.SetActive(true);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void GameRoom(){
       scenenr = 0;
       Time.timeScale = 1;
       Game.SetActive(true);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void HumanMenu(){
        scenenr =2;
       Time.timeScale = 0;
       Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(true);
       phisical.SetActive(false);
   }
   public void Intelect(){
       scenenr = 3;
       Time.timeScale = 0;
       Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(true);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void phisic(){
       scenenr = 4;
       Time.timeScale = 0;
     Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(true);
   }
   
}
