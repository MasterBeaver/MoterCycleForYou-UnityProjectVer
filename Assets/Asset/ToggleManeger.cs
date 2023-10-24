using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleManeger : MonoBehaviour
{
    [SerializeField] public GameObject ContentHolder;

    [SerializeField] public GameObject[] allElement;

    [SerializeField] public Info[] infoElement;
    
    [Header("Brand")]
    [SerializeField] public GameObject[] hondaElement;
    [SerializeField] public GameObject[] yamahaElement;
    [SerializeField] public GameObject[] vespaElement;
    
    [Header("Price")]
    [SerializeField] public int[] priceElement;

    [Header("Distance")]
    [SerializeField] public GameObject[] nearElement;
    [SerializeField] public GameObject[] mediumElement;
    [SerializeField] public GameObject[] longDistanceElement;


    public GameObject minPrice;

    public GameObject maxPrice;

    int totalElement;

    bool price;

    int Num;

    int Numm;

    string minText;
    string maxText;

    void Start()
    {
        totalElement = ContentHolder.transform.childCount;

        allElement = new GameObject[totalElement];

        infoElement = new Info[totalElement];

        hondaElement = new GameObject[totalElement];
        yamahaElement = new GameObject[totalElement];
        vespaElement = new GameObject[totalElement];
        nearElement = new GameObject[totalElement];
        mediumElement = new GameObject[totalElement];
        longDistanceElement = new GameObject[totalElement];

        priceElement = new int[totalElement];



        price = false;

        Num = 0;

        Numm = 0;


        

        for (int i = 0; i < totalElement; i++)
        {
            allElement[i] = ContentHolder.transform.GetChild(i).gameObject;
            infoElement[i] = allElement[i].GetComponent<Info>();
            priceElement[i] = infoElement[i].Price;
        }

       

        for (int i = 0; i < totalElement; i++)
        {
            if(infoElement[i].Brand == "Honda")
            {
               hondaElement[i] = allElement[i];
            }

            if(infoElement[i].Brand == "Yamaha")
            {
               yamahaElement[i] = allElement[i];
            }

            if(infoElement[i].Brand == "Vespa")
            {
               vespaElement[i] = allElement[i];
            }

            if(infoElement[i].Distance == "Near")
            {
               nearElement[i] = allElement[i];
            }

            if(infoElement[i].Distance == "Medium")
            {
               mediumElement[i] = allElement[i];
            }

            if(infoElement[i].Distance == "Long Distance")
            {
               longDistanceElement[i] = allElement[i];
            }
        }
    }

    public void Honda()
    {
        Numm = 1;
        Set(hondaElement);  
    }

    public void Yamaha()
    {
        Numm = 2;
        Set(yamahaElement);  
    }

    public void Vespa()
    {
        Numm = 3;
        Set(vespaElement);
    }

    public void Set(GameObject[] brand)
    {
        for(int i = 0; i < brand.Length; i++)
        {
            allElement[i].SetActive(false);
        }

        for(int i = 0; i < brand.Length; i++)
        {
            if(brand[i] != null)
            {
              brand[i].SetActive(true);
            }
        }
        Check();
    }

    public void Near()
    {
       Num = 1;
       Distance();
    }

    public void Medium()
    {
        Num = 2;
       Distance();
    }

    public void LongDistance()
    {
        Num = 3;
       Distance();
    }

    public void All()
    {
        Numm = 0;
        for(int i = 0; i < totalElement; i++)
        {
            allElement[i].SetActive(true);
        }
        Check();
    }

    public void AllDistance()
    {
        switch(Numm)
        {
         case 0:
          for(int i = 0; i < totalElement; i++)
          {
            allElement[i].SetActive(true);
          }
          break;
         case 1:
          Set(hondaElement);
          break;
         case 2:
          Set(yamahaElement);
          break;
         case 3:
          Set(vespaElement);
          break;
        }
        Num = 0;
        Check();


    }

    public void Distance()
    {
        switch(Num)
        {
            case 0:
              Debug.Log("0");
              break;
            case 1:
              AllDistance();
              for(int i = 0; i < totalElement; i++)
              {
                 if(mediumElement[i] != null)
                   {
                     mediumElement[i].SetActive(false);
                   }
                 if(longDistanceElement[i] != null)
                   {
                     longDistanceElement[i].SetActive(false);
                   }
              }
              break;
            case 2:
              AllDistance();
              for(int i = 0; i < totalElement; i++)
              {
                 if(nearElement[i] != null)
                   {
                     nearElement[i].SetActive(false);
                   }
                 if(longDistanceElement[i] != null)
                   {
                     longDistanceElement[i].SetActive(false);
                   }
              }
              break;
            case 3:
              AllDistance();
              for(int i = 0; i < totalElement; i++)
              {
                 if(nearElement[i] != null)
                   {
                     nearElement[i].SetActive(false);
                   }
                 if(mediumElement[i] != null)
                   {
                     mediumElement[i].SetActive(false);
                   }
              }
              break;

        }
    }


    public void insertPrice()
    {
        price = true;
        
        minText = minPrice.GetComponent<TMP_InputField>().text;
        maxText = maxPrice.GetComponent<TMP_InputField>().text;
        
        for(int i = 0; i < totalElement; i++)
        {
            if(priceElement[i] < System.Int32.Parse(minText) || priceElement[i] > System.Int32.Parse(maxText))
            {
                allElement[i].SetActive(false);
            }
        }
    }

    public void Clear()
    {
       price = false;
       minPrice.GetComponent<TMP_InputField>().text = "";
       maxPrice.GetComponent<TMP_InputField>().text = "";
    }

    public void Check()
    {
       
       

       if(price == true)
        {
            insertPrice();
        }  
    }
}
