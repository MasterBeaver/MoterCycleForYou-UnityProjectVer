using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject home;
    public GameObject main;
    public GameObject credit;
    public GameObject archive;
    public GameObject Infomation;
    public GameObject admin;

    bool isarchive = false;


    public void Homee()
    {
        isarchive = false;

        home.SetActive(true);
        main.SetActive(false);
        credit.SetActive(false);
        archive.SetActive(false);
        Infomation.SetActive(false);
    }

    public void Main()
    {
        if(isarchive == true)
        {
            credit.SetActive(false);
            main.SetActive(false);
            home.SetActive(false);
            archive.SetActive(true);
            Infomation.SetActive(false);
        }
        else
        {
            main.SetActive(true);
            home.SetActive(false);
            credit.SetActive(false);
            archive.SetActive(false);
            Infomation.SetActive(false);
        }
    }

    public void Credit()
    {
        credit.SetActive(true);
        main.SetActive(false);
        home.SetActive(false);
        archive.SetActive(false);
        Infomation.SetActive(false);
    }

    public void Archive()
    {
        isarchive = true;

        credit.SetActive(false);
        main.SetActive(false);
        home.SetActive(false);
        archive.SetActive(true);
        Infomation.SetActive(false);
    }

    public void AdminOpen()
    {
        admin.SetActive(true);
    }

    public void AdminClose()
    {
        admin.SetActive(false);
    }
}
