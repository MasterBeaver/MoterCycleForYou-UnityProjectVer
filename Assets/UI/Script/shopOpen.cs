using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopOpen : MonoBehaviour
{
    public CanvasGroup Shop;
    bool condition = true;
    public KeyCode Key = KeyCode.F;

    void Start()
    {
        
    }


    public void ShopClose()
    {
        Shop.alpha = Mathf.Lerp(1,0,2);
        Shop.blocksRaycasts = false;
        Shop.interactable = false;
        
    }
    
    void Update()
    {
        Debug.Log(Shop.alpha);
        
        if(condition)
        {
             if(Input.GetKeyDown(Key))
             {
                Shop.alpha = Mathf.Lerp(0,1,2);
                Shop.interactable = true;
                Shop.blocksRaycasts = true;
                
             }
        }
    }
}
