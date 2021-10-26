using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticPologenie : MonoBehaviour
{
    private Vector3 staticPolo;

    void Awake()
    {
        staticPolo = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, staticPolo.z);
    }
}
