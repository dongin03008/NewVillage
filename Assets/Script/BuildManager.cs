using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject BuildMenu;
    public GameObject[] building;
    public GameObject[] buildpos;
    public void Build1()
    { 
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(building[0], buildpos[Random.Range(0,10)].transform.position, Quaternion.identity);
        BuildMenu.SetActive(false);
    }
    public void Build2()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(building[1], buildpos[Random.Range(0, 10)].transform.position, Quaternion.identity);
        BuildMenu.SetActive(false);
    }
    public void Build3()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(building[2], buildpos[Random.Range(0, 10)].transform.position, Quaternion.identity);
        BuildMenu.SetActive(false);
    }
    public void Build4()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(building[3], buildpos[Random.Range(0, 10)].transform.position, Quaternion.identity);
        BuildMenu.SetActive(false);
    }
}
