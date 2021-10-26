using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dvigenieDorogi : MonoBehaviour
{
    public GameObject povodok;
    private float timer;
    public float prodolgitelnostmUrovny;

    void Update()
    {
        if (povodok == true)
        {
            timer += 1 * Time.deltaTime;

            if (timer < prodolgitelnostmUrovny)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, povodok.transform.localPosition.z);
            }
        }
    }
}
