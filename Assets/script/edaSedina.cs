using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edaSedina : MonoBehaviour
{
    private bool eduseli;
    private float schechik;
    private GameObject zmey;

    private void OnTriggerEnter(Collider zmeiSelEdu)
    {
        if (zmeiSelEdu.tag == "zmei")
        {
            eduseli = true;
            zmey = zmeiSelEdu.gameObject;
        }
    }

    private void Update()
    {
        if (eduseli == true)
        {
            transform.LookAt(zmey.transform);

            transform.Translate(0, 0, 10);

        schechik += 8 * Time.deltaTime;

            transform.localScale = new Vector3(Mathf.Lerp(50, 20, schechik), Mathf.Lerp(50, 20, schechik), Mathf.Lerp(50, 20, schechik));
        }
        if (transform.localScale.x <= 22)
        {
            Destroy(gameObject);
        }
    }
}
