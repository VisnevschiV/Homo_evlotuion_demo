using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagment : MonoBehaviour
{
   public void WorldMenu(){
       SceneManager.LoadScene(4);
   }
   public void GameRoom(){
       SceneManager.LoadScene(0);
   }
   public void HumanMenu(){
       SceneManager.LoadScene(1);
   }
   public void Intelect(){
       SceneManager.LoadScene(2);
   }
   public void phisic(){
       SceneManager.LoadScene(3);
   }
}
