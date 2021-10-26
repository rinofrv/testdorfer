using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viravnivanie : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity.normalized * 2;
    }
}
