using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Player : MonoBehaviour
{
    [SerializeField] private GameObject _traces;
   // [SerializeField] private GameObject _buttons;
    [SerializeField] public float _speedEnemy;
    private bool _moove;
    private Vector3 _target;
    private bool _finish = true;
    private Collider2D collider2d;
  //  public GameObject Versus_img;
    public float speed;
    private Quaternion rotate;
    private bool _lowSpeed = false;


    void Update()
    {
        
                Move();
        
        if (_moove == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, speed * Time.deltaTime);
            TracesInstantiate(_finish);
            
        }

        if (transform.position == _target)
        {
            _moove = false;
        }

        

    }

    private void Move()
    {
        Speed();
        Vector2 directionPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(directionPoint.y, directionPoint.x) * Mathf.Rad2Deg;
        rotate = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        if (Input.touchCount == 1)
        {
            Touch touchScreen = Input.GetTouch(0);
            Vector2 touchFirst = touchScreen.deltaPosition;
            if (touchScreen.phase == TouchPhase.Ended && touchFirst == new Vector2(0, 0))
            {
                _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                _target.z = transform.position.z;
                _moove = true;
            }

        }
    }

    private void TracesInstantiate(bool finish)
    {

        if (finish == true)
            StartCoroutine(Treas());
        _finish = false;
    }

    IEnumerator Treas()
    {

        Instantiate(_traces, transform.position, rotate);
        yield return new WaitForSeconds(0.5f);
        _finish = true;
    }

   

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "NMove")
        {
            Debug.Log("Can't Move");
        }
        else
        {
            _lowSpeed = false;
        }
    }


    public void Speed()
    {
        var enemy = GameObject.FindGameObjectsWithTag("enemy");
        if (_lowSpeed == true)
        {

            foreach (var p in enemy)
            {
                p.gameObject.GetComponent<Random_Pozition>().Speed(1);
            }
        }


    }
}
