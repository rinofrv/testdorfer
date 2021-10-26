using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject povodok;

    void Update()
    {
        //transform.position = new Vector3(transform.position.x, povodok.transform.position.y+1200, povodok.transform.position.z-1100);
        transform.position = Vector3.Lerp(transform.position, new Vector3 (transform.position.x, povodok.transform.position.y + 1200, povodok.transform.position.z - 1100), Time.deltaTime * 5);
    }
}
