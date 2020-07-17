using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Vector3 _touchPozition;
    private float zoomIn = 1;
    private float zoomOut = 8;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _touchPozition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroBefo = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOneBefo = touchOne.position - touchOne.deltaPosition;

            float magnitudeZero = (touchZeroBefo - touchOneBefo).magnitude;
            float magnitudeOne = (touchZero.position - touchOne.position).magnitude;

            float difference = magnitudeOne - magnitudeZero;

            zoom(difference*0.001f);

        }
        else
        {
            if (Input.touchCount == 1)
            {
                Touch touchBegin = Input.GetTouch(0);
                if (touchBegin.phase == TouchPhase.Moved)
                {
                    Vector3 direction = _touchPozition - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    transform.position += direction;
                }

            }

            
               
            
        }
    }
    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomIn, zoomOut);
    }

}

   

