using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaunPregrad : MonoBehaviour
{
    private float timer;
    public GameObject spaun1;
    public GameObject spaun2;
    public GameObject spaun3;
    public GameObject manpregrada;
    public GameObject koluchka;
    public GameObject kristal;
    private GameObject pregrada;
    public GameObject zmey;
    public int randomCvet;
    public float levoPravo;
    public bool poyvlenieLudei;
    public int schetchik;
    public GameObject chekpointprefab;
    private Color cvetChekpoint;
    public GameObject obolochkazmei;
    public GameObject strelka;
    public float vremyVozniknoveniyEdi;

    public void Start()
    {
        cvetChekpoint = obolochkazmei.GetComponent<Renderer>().material.color;
        vremyVozniknoveniyEdi = 0.8f;
        poyvlenieLudei = true;
    }

    public void umenshenieVremeniEdi()
    {
        vremyVozniknoveniyEdi = 0.8f / 3;
    }

    public void uvelichenieVremeniEdi()
    {
        vremyVozniknoveniyEdi = 0.8f;
    }


    private void izmenenieCveta()
    {
        switch (randomCvet)
        {
            case 1:
                pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 2:
                pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 3:
                pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 4:
                pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 5:
                pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.green;
                break;
        }

        if(pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color == zmey.GetComponent<Renderer>().material.color)
        {
            randomCvet = Random.Range(1, 5);
            izmenenieCveta();
        }
    }

    private void cvetzmei()
        {
        pregrada.transform.GetChild(1).GetComponent<Renderer>().material.color = cvetChekpoint;
        }

    private void spaunLudi()
        {
       levoPravo = Random.Range(0.0f, 2.0f);
        randomCvet = Random.Range(1, 5);

        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x + Random.Range(25,80), spaun1.transform.position.y, spaun1.transform.position.z + Random.Range(25, 80));
        if(levoPravo < 1)
        {
            cvetzmei();
        }
        else { izmenenieCveta(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x + Random.Range(25, 100), spaun1.transform.position.y, spaun1.transform.position.z - Random.Range(25, 100));
        if (levoPravo < 1)
        {
            cvetzmei();
        }
        else { izmenenieCveta(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x - Random.Range(25, 100), spaun1.transform.position.y, spaun1.transform.position.z + Random.Range(25, 100));
        if (levoPravo < 1)
        {
            cvetzmei();
        }
        else { izmenenieCveta(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x - Random.Range(25, 50), spaun1.transform.position.y, spaun1.transform.position.z - Random.Range(25, 50));
        if (levoPravo < 1)
        {
            cvetzmei();
        }
        else { izmenenieCveta(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x + Random.Range(25, 100), spaun3.transform.position.y, spaun3.transform.position.z + Random.Range(25, 100));
        if (levoPravo < 1)
        {
            izmenenieCveta();
        }
        else { cvetzmei(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x + Random.Range(25, 100), spaun3.transform.position.y, spaun3.transform.position.z - Random.Range(25, 100));
        if (levoPravo < 1)
        {
            izmenenieCveta();
        }
        else { cvetzmei(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x - Random.Range(25, 100), spaun3.transform.position.y, spaun3.transform.position.z + Random.Range(25, 100));
        if (levoPravo < 1)
        {
            izmenenieCveta();
        }
        else { cvetzmei(); }
        pregrada = Instantiate<GameObject>(manpregrada);
        pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x - Random.Range(25, 50), spaun3.transform.position.y, spaun3.transform.position.z - Random.Range(25, 50));
        if (levoPravo < 1)
        {
            izmenenieCveta();
        }
        else { cvetzmei(); }
    }

    private void ustanovkaCvetaChekpointa()
    {
        randomCvet = Random.Range(1, 5);

        switch (randomCvet)
        {
            case 1:
                pregrada.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 2:
                pregrada.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 3:
                pregrada.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 4:
                pregrada.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 5:
                pregrada.GetComponent<Renderer>().material.color = Color.green;
                break;
        }

        cvetChekpoint = pregrada.GetComponent<Renderer>().material.color;
    }

    private void spaunKristal()
    {
        levoPravo = Random.Range(0.0f, 2.0f);
        if(levoPravo < 1)
        {
            pregrada = Instantiate<GameObject>(kristal);
            pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x, spaun1.transform.position.y+50, spaun1.transform.position.z);

            pregrada = Instantiate<GameObject>(koluchka);
            pregrada.transform.localPosition = new Vector3(spaun2.transform.position.x, spaun2.transform.position.y+50, spaun2.transform.position.z);

            pregrada = Instantiate<GameObject>(kristal);
            pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x, spaun3.transform.position.y+50, spaun3.transform.position.z);
        }

        if (levoPravo > 1)
        {
            pregrada = Instantiate<GameObject>(koluchka);
            pregrada.transform.localPosition = new Vector3(spaun1.transform.position.x, spaun1.transform.position.y+50, spaun1.transform.position.z);

            pregrada = Instantiate<GameObject>(kristal);
            pregrada.transform.localPosition = new Vector3(spaun2.transform.position.x, spaun2.transform.position.y+50, spaun2.transform.position.z);

            pregrada = Instantiate<GameObject>(koluchka);
            pregrada.transform.localPosition = new Vector3(spaun3.transform.position.x, spaun3.transform.position.y+50, spaun3.transform.position.z);
        }

        if (schetchik == 5)
        {
            pregrada = Instantiate<GameObject>(chekpointprefab);
            pregrada.transform.localPosition = new Vector3(spaun2.transform.position.x, spaun2.transform.position.y-38, spaun2.transform.position.z);

            ustanovkaCvetaChekpointa();

            if(obolochkazmei.GetComponent<Renderer>().material.color == cvetChekpoint)
            {
                ustanovkaCvetaChekpointa();
            }
        }

    }

    void Update()
    {
        if (transform.position.z < strelka.transform.position.z-6000)
        { timer += 1 * Time.deltaTime; }

        if (schetchik > 5)
        {
            switch (poyvlenieLudei)
            {
                case true:
                    poyvlenieLudei = false;
                    break;
                case false:
                    poyvlenieLudei = true;
                    break;
            }
                schetchik = 0;
        }

        if (timer > vremyVozniknoveniyEdi && poyvlenieLudei == true)
            {
                spaunLudi();
                timer = 0;
            schetchik += 1;
            }

        if (timer > vremyVozniknoveniyEdi && poyvlenieLudei == false)
            {
                spaunKristal();
                timer = 0;
                schetchik += 1;
            }
    }
}
