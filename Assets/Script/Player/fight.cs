using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fight : MonoBehaviour
{
    
    public GameObject FScene;
    public float time;

    public  Text E_Speed;
    public  Text E_Nr;
    public  Text E_Damage;
    public  Text E_HP;
    private int speed;
    private int Nr;
    private int Damage;
    private int HP;
    private GameObject Enem;

    private int enemy_type=0;//0-def;; 1-bear;;
    
    public GameObject Camera;
    public GameObject non_fight;
    public GameObject start_fight;
    void OnCollisionEnter2D( Collision2D collisionInfo){   
        Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.name == "bear(Clone)"){
            Debug.Log("we hit a bear");
            Enem = collisionInfo.collider.gameObject;
            enemy_type = 1;
            
            StartFight();
        }
   }

    void StartFight(){
       Time.timeScale = 0;
       non_fight.SetActive(false);
       start_fight.SetActive(true);
       float x = Camera.transform.position.x;
       float y = Camera.transform.position.y;
       FScene.transform.position = new Vector3(x,y,50);
       FScene.SetActive(true);
       LeanTween.scale(FScene , new Vector3(0.32f,0.32f,100), time);
       if(enemy_type == 1){
           Damage= Random.Range(10, 80);
           E_Damage.text = Damage.ToString();
           HP= Random.Range(10, 80);
           E_HP.text = HP.ToString();
           Nr= Random.Range(10, 80);
           E_Nr.text = Nr.ToString();
           speed= Random.Range(10, 80);
           E_Speed.text = speed.ToString();
       }
    }

    public void Fight(){
            if(player.nr*player.Damage/player.ill > Nr*Damage){
                Debug.Log("Winner");
                Destroy(Enem);
                
            }else{Debug.Log("Loser");}
                
                Time.timeScale = 1;
                non_fight.SetActive(true);
                start_fight.SetActive(false);
                FScene.SetActive(false);
    }
    public void Run(){
            if(player.speed/player.ill > speed){
                Debug.Log("Runned away");
                
            }else{Debug.Log("Still There");}
            Time.timeScale = 1;
                non_fight.SetActive(true);
                start_fight.SetActive(false);
                FScene.SetActive(false);
    }
    public void Bueff(){
        if(player.speed*player.Damage/player.ill > Damage){
                Debug.Log("He's scared");
                
            }else{Debug.Log("He's Still Here");}
            Time.timeScale = 1;
                non_fight.SetActive(true);
                start_fight.SetActive(false);
                FScene.SetActive(false);

    }
}
