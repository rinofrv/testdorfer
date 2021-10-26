using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cvetZmei : MonoBehaviour
{
    public Color cvetzmei;

    private void Start()
    {
        int randomCvet = Random.Range(1,5);
        switch (randomCvet)
        {
            case 1:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 3:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 5:
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}
