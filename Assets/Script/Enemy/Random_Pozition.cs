using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Random_Pozition : MonoBehaviour
{
    [SerializeField] private int maxX;
    [SerializeField] private int minX;
    [SerializeField] private int maxY;
    [SerializeField] private int minY;
    [SerializeField] private float speed;

    //[SerializeField] private GameObject _traces;
    private GameObject _player;
    [SerializeField] private float _distanceToAtack;
    [SerializeField] private int breakMaxX;
    [SerializeField] private int breakMinX;
    [SerializeField] private int breakMaxY;
    [SerializeField] private int breakMinY;
    bool _finish = true;
    private int likelyToBreakTheLimit;

    private bool reachPoint = true;

    private int i=0;
  


    public void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Vector2.Distance(transform.localPosition, _player.transform.position) < _distanceToAtack)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, _player.transform.position,
                speed * Time.deltaTime);
        }
        else
        {
            
            if(reachPoint == true)
            {
               //the probability the bear leaves his natural place
               reachPoint =false;
               likelyToBreakTheLimit = Random.Range(-1, 101);
               if (likelyToBreakTheLimit <= 1)
               {
                   //dif he does we use BreakMin/Max          
                    int breakX = Random.Range(breakMinX, breakMaxX);
                    int breakY = Random.Range(breakMinY, breakMaxY);
                    StartCoroutine(StartMove(breakX, breakY));  
                }else
               {
                   // if he doesnt we go random
                    var randomX = Random.Range(minX, maxX);
                    var randomY = Random.Range(minY, maxY);
                    StartCoroutine(StartMove(randomX, randomY));
                }
            }else
            {
                //functia responsabila de urme
                //Starts();
            }
        }

    }

    // if he hits the map margins
    void OnCollisionEnter2D(){
        Debug.Log("water");
        reachPoint = true;
    }

    IEnumerator StartMove(int pozitionX, int pozitionY)
    {
        Vector2 distance = new Vector2(pozitionX, pozitionY);
     Checkpoint:
        i=0;
        while (/*Vector2.Distance(transform.position, distance) > 0.5f*/!reachPoint)
        {
            
            i++;
            transform.position = Vector2.MoveTowards(transform.position, distance, speed * Time.deltaTime);
            if(Vector2.Distance(transform.position, distance) <= 0.5f){
                reachPoint = true;
            }
            // cand I ajunge la 100 iesim din while ca sa vedem daca am atins cv si schimbam directia
            if(i > 100){
                break;
                goto Checkpoint;
            }
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        reachPoint = true;
    }

    public void Starts()
    {
        if (_finish == true)
            //StartCoroutine(Treas());
        _finish = false;
    }

   IEnumerator Treas()
    {

        //Instantiate(_traces, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        _finish = true;

    }

    public void Speed(int amount)
    {
        speed = amount;
    }
}