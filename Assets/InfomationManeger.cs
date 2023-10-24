using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class InfomationManeger : MonoBehaviour
{
    Info info; 
    public string name;
    public Image image;

    public GameObject main;
    public GameObject infomation;
    public GameObject archive;

    [Header ("Main")]
    public TextMeshProUGUI modelOut;
    public TextMeshProUGUI priceOut;
    public Image iconOut;

    [Header ("Oil")]
    public TextMeshProUGUI Oil1;
    public TextMeshProUGUI Oil2;
    public TextMeshProUGUI Oil3;
    public TextMeshProUGUI bkm1;
    public TextMeshProUGUI bkm2;
    public TextMeshProUGUI bkm3;
    
    [Header ("Main")]
    public TextMeshProUGUI brandOut;
    public TextMeshProUGUI distanceOut;
    public TextMeshProUGUI engineOut;
    public TextMeshProUGUI ccOut;
    public TextMeshProUGUI fualTankSizeOut;

    
    public void Click()
    {
        Debug.Log("AAAAAAAAAAAAAAA");
        info = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject.GetComponent<Info>();
        name = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject.name;
        image = EventSystem.current.currentSelectedGameObject.transform.GetChild(2).GetComponent<Image>();
        SendInfo();
        main.SetActive(false);
        archive.SetActive(false);
        infomation.SetActive(true);
    }

    public void SendInfo()
    {
        modelOut.SetText(name.ToString());
        priceOut.SetText(info.Price.ToString());
        iconOut.sprite = image.sprite;
        brandOut.SetText(info.Brand.ToString());
        distanceOut.SetText(info.Distance.ToString());
        engineOut.SetText(info.Engine.ToString());
        ccOut.SetText(info.CC.ToString());
        fualTankSizeOut.SetText(info.FualTankSize.ToString());

        float gas91 =  Gas.Gas91 * info.kmPl;
        float gas95 =  Gas.Gas95 * info.kmPl;
        float gasE20 =  Gas.GasE20 * info.kmPl;

        if(info.Gasohol == true)
        {
            Oil1.SetText("Gasohol 91");
            bkm1.SetText(gas91.ToString("F2"));
            Oil2.SetText("Gasohol 95");
            bkm2.SetText(gas95.ToString("F2"));
            Oil3.SetText("Gasohol 95 : E 20");
            bkm3.SetText(gasE20.ToString("F2"));
        }
        else
        {
            Oil1.SetText("Gasohol 95");
            bkm1.SetText(gas95.ToString("F2"));
            Oil2.SetText("Gasohol 95 : E 20");
            bkm2.SetText(gasE20.ToString("F2"));
            Oil3.SetText("Gasohol 91");
            bkm3.SetText(gas91.ToString("F2"));
        }

    }




}
