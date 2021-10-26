using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procesPoedaniy : MonoBehaviour
{
    public GameObject zmei;
    public GameObject zmeiObolochka;
    public GameObject[] posvonki = new GameObject[16];
    public GameObject povodok;
    public GameObject proigralPrefab;
    public GameObject ekran;
    public int schetForsag;

    public void sbrosSchetchikForsag()
    {
        schetForsag = 0;
    }

    private void OnTriggerEnter(Collider eda)
    {
        if(eda.tag == "eda")
        {
            zmei.GetComponent<Animator>().Play("glotanie", 0, 0);
            zmei.GetComponent<schetchikEdi>().uvelichenieKristalov();
            schetForsag += 1;

            if (schetForsag > 3)
            {
                if (povodok == true)
                {
                    povodok.GetComponent<upravlenieZmeei>().forsag();
                    povodok.GetComponent<spaunPregrad>().umenshenieVremeniEdi();
                }
            }
        }

        if (eda.tag == "edaman")
        {
            zmei.GetComponent<Animator>().Play("glotanie", 0, 0);

            if (eda.transform.GetChild(1).GetComponent<Renderer>().material.color != zmeiObolochka.GetComponent<Renderer>().material.color)
            {
                if (povodok == true)
                {
                    if (povodok.GetComponent<upravlenieZmeei>().forsagAktivirivan == false)
                    {
                        Destroy(povodok);
                        GameObject proigrishText = Instantiate(proigralPrefab) as GameObject;
                        proigrishText.transform.SetParent(ekran.gameObject.transform, false);
                    }
                }
            }

            if (eda.transform.GetChild(1).GetComponent<Renderer>().material.color == zmeiObolochka.GetComponent<Renderer>().material.color)
            {
                int i;
                for(i=0; i < 16; i++)
                {
                    posvonki[i].GetComponent<dvigenieZvena>().uvelichenieZmei();
                }
            }
            zmei.GetComponent<schetchikEdi>().uvelichenieMan();
            schetForsag = 0;
        }

        if(eda.tag == "koluchka")
        {
            zmei.GetComponent<Animator>().Play("glotanie", 0, 0);
            if (povodok == true)
            {
                if (povodok.GetComponent<upravlenieZmeei>().forsagAktivirivan == false)
                {
                    Destroy(povodok);
                    GameObject proigrishText = Instantiate(proigralPrefab) as GameObject;
                    proigrishText.transform.SetParent(ekran.gameObject.transform, false);
                }
            }
        }
    }
}
