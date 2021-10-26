using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upravlenieZmeei : MonoBehaviour
{
    private float x;
    public Vector3 pologenieMishi;
    public Vector3 peremeshenie;
    private bool viigralaZmey;
    public bool forsagAktivirivan;
    private float timer;
    public GameObject zmei;
    public GameObject zmeiKost;

    public void forsag()
    {
        forsagAktivirivan = true;
    }


    public void viigrish()
    {
        viigralaZmey = true;
    }

    void FixedUpdate()
    {
        if (viigralaZmey == false && forsagAktivirivan == false)
        {
            
            x = Input.mousePosition.x;
            Camera camera = Camera.main;
            pologenieMishi = camera.ScreenToWorldPoint(new Vector3(x, 0, camera.nearClipPlane));
            if (Input.GetMouseButton(0))
            {
                if (x > 0 && x < Screen.height)
                { transform.localPosition = new Vector3(pologenieMishi.x, transform.localPosition.y, transform.localPosition.z); }
            }
            transform.Translate(peremeshenie);
        }

        if(forsagAktivirivan == true)
        {
            x = Screen.width / 2;
            Camera camera = Camera.main;

            pologenieMishi = camera.ScreenToWorldPoint(new Vector3(x, 0, camera.nearClipPlane));

            if (x > 0 && x < Screen.width)
            { transform.localPosition = new Vector3(pologenieMishi.x, transform.localPosition.y, transform.localPosition.z); }

            transform.Translate(peremeshenie * 3);
            timer += 1 * Time.deltaTime;
        }

        if(timer > 5)
        {
            forsagAktivirivan = false;
            GetComponent<spaunPregrad>().uvelichenieVremeniEdi();
            timer = 0;
            zmei.GetComponent<schetchikEdi>().obnulenieKristalov();
            zmeiKost.GetComponent<procesPoedaniy>().sbrosSchetchikForsag();
        }
    }
}
