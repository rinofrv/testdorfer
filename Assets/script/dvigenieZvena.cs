using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class dvigenieZvena : MonoBehaviour
{
    public GameObject zveno;
    private float distanciy;
    public Camera glavnayKamera;
    public float distanciyDoCeli;
    public GameObject povodok;

    public void uvelichenieZmei()
    {
        if (distanciyDoCeli <= 50)
        { distanciyDoCeli += 1; }
        if (distanciyDoCeli > 45)
        { distanciyDoCeli += 0.3f; }

    }

    void FixedUpdate()
    {
        if (povodok == true)
        {
            Vector3 direction = zveno.transform.position - transform.position;

            float distance = direction.magnitude;

            distanciy = Vector3.Distance(zveno.transform.position, transform.position);

            if (distanciy > distanciyDoCeli)
            {
                transform.position += direction.normalized * (distanciy - distanciyDoCeli);

                transform.LookAt(zveno.transform);
            }
            if (distanciyDoCeli > 5.2f)
            {
                transform.Translate(0, 0, Mathf.Lerp(0, 20, distanciy * Time.deltaTime));
            }
        }
    }

    private void LateUpdate()
    {
        if (povodok == true && glavnayKamera == true)
        {
            glavnayKamera.transform.position = new Vector3(glavnayKamera.transform.position.x, povodok.transform.position.y+1300, povodok.transform.position.z-1100);
        }
    }
}
