using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class schetchikEdi : MonoBehaviour
{
    public Text textKolichestvoKristalov;
    public Text textKolichestvoMan;
    private int kolichestvoKristalov;
    private int kolichestvoMan;

    public void uvelichenieKristalov()
    {
        kolichestvoKristalov += 1;
    }

    public void uvelichenieMan()
    {
        kolichestvoMan += 1;
    }

    public void obnulenieKristalov()
    {
        kolichestvoKristalov = 0;
    }

    void Update()
    {
        textKolichestvoKristalov.text = kolichestvoKristalov.ToString();
        textKolichestvoMan.text = kolichestvoMan.ToString();
    }
}
