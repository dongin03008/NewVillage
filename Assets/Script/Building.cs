using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int money=0;
    public int addMoney=0;
    public int addEnergy=0;
    float currentTime;
    private GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("MenuCanvas");
        menu.GetComponent<TextCtrl>().money -= money;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > 30)
        {
            menu.GetComponent<TextCtrl>().money += addMoney;
            menu.GetComponent<TextCtrl>().energy += addEnergy;
            currentTime = 0;
        }
    }
}
