using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCtrl : MonoBehaviour
{
    public int money = 100;
    public int energy = 100;
    public TMP_Text moneytext;
    public TMP_Text energytext;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneytext.text = "µ·"+money;
        energytext.text = "È°µ¿·Â" + energy;

    }
}
