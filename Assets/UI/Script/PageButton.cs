using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageButton : MonoBehaviour
{
    
    public GameObject turnPage;
    private bool PageStatus;

    void Start()
    {
        PageStatus = false;
    }
    
    void Update()
    {
        if (PageStatus == true && turnPage!= PageCurrent.Page)
        {
            turnPage.SetActive(false);
            PageStatus = false;
        }
        
    }
    
    public void changePage()
    {
        PageStatus = true;
        PageCurrent.Page.SetActive(false);
        turnPage.SetActive(true);
        PageCurrent.Page = turnPage;

        Debug.Log("turn");
    }
}
