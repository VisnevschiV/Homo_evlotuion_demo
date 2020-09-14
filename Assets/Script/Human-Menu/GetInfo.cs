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
        evolve.selectedParameter = parameter;
    }

}
