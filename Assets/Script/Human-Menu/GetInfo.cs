using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class GetInfo : MonoBehaviour
{
    public GameObject info;
    public GameObject evolve_button;
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
    }

}
