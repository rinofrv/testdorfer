using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viigrish : MonoBehaviour
{
    public GameObject povodok;
    public GameObject ekran;
    public GameObject finishPrefab;

    private void OnTriggerEnter(Collider viigralaZmey)
    {
        if(viigralaZmey.tag == "zmei")
        {
            povodok.GetComponent<upravlenieZmeei>().viigrish();
        }

        GameObject finishText = Instantiate(finishPrefab) as GameObject;
        finishText.transform.SetParent(ekran.gameObject.transform, false);

        Destroy (povodok);

    }
}
