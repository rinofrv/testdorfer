using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class udalenieEda : MonoBehaviour
{
    private void OnTriggerEnter(Collider edaPopala)
    {
            Destroy(edaPopala.gameObject);
    }
}
