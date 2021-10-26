using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ismenenieCvetaDima : MonoBehaviour
{
    public ParticleSystem dim1;
    public ParticleSystem dim2;
    public ParticleSystem dim3;
    public ParticleSystem dim4;
    public ParticleSystem dim5;
    public GameObject obolochkazmei;

    void Start()
    {
        obolochkazmei = GameObject.Find("obolochka");


        ParticleSystem.MainModule main = dim1.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<Renderer>().material.color;

        main = dim2.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<Renderer>().material.color;

        main = dim3.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<Renderer>().material.color;

        main = dim4.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<Renderer>().material.color;

        main = dim5.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<Renderer>().material.color;
    }


    private void OnTriggerStay (Collider zmeyPopala)
    {
        if (zmeyPopala.tag == "zmei")
        {
            obolochkazmei.GetComponent<Renderer>().material.color = GetComponent<Renderer>().material.color;
        }
        if(zmeyPopala.tag == "eda" || zmeyPopala.tag == "koluchka")
        {
            Destroy(zmeyPopala.gameObject);
        }
    }
}
