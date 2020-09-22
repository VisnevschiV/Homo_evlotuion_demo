using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    
    public GameObject FScene;
    public float time;
    
    public GameObject Camera;
    public GameObject non_fight;
    public GameObject start_fight;

   void OnCollisionEnter2D( Collision2D collisionInfo){
    
        Debug.Log(collisionInfo.collider.name);
        StartFight();


   }

   void StartFight(){
       non_fight.SetActive(false);
       start_fight.SetActive(true);
       float x = Camera.transform.position.x;
       float y = Camera.transform.position.y;
       FScene.transform.position = new Vector3(x,y,50);
       FScene.SetActive(true);
       LeanTween.scale(FScene , new Vector3(0.32f,0.32f,100), time);
   }
}
