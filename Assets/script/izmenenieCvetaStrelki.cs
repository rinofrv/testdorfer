using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izmenenieCvetaStrelki : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        { GetComponent<Renderer>().material.color = Color.Lerp(Color.cyan, Color.red, Mathf.PingPong(Time.time, 0.6f)); }
    }
}
