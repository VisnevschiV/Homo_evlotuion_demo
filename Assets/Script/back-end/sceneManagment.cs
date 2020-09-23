using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagment : MonoBehaviour
{
    public GameObject Human;
    private bool H = false;
    public GameObject Game;
    private bool G = true;
    public GameObject World;
    private bool W = false;
    public GameObject Intelectual;
    private bool I = false;
    public GameObject phisical;
    private bool P = false;
   public void WorldMenu(){
       Time.timeScale = 0;
      Game.SetActive(false);
       World.SetActive(true);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void GameRoom(){
       Time.timeScale = 1;
       Game.SetActive(true);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void HumanMenu(){
       Time.timeScale = 0;
       Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(true);
       phisical.SetActive(false);
   }
   public void Intelect(){
       Time.timeScale = 0;
       Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(true);
       Human.SetActive(false);
       phisical.SetActive(false);
       
   }
   public void phisic(){
       Time.timeScale = 0;
     Game.SetActive(false);
       World.SetActive(false);
       Intelectual.SetActive(false);
       Human.SetActive(false);
       phisical.SetActive(true);
   }
   
}
