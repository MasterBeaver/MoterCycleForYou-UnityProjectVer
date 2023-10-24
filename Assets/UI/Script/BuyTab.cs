// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;


// public class BuyTab : MonoBehaviour
// {
//     [SerializeField] private CanvasGroup cg;
//     public ItemOpen itemBuy;

    
//     void Start()
//     {
//         cg = gameObject.GetComponent<CanvasGroup>();
       
//         cg.alpha = 0;
//         cg.blocksRaycasts = false;

       
//     }
    
//     public void CloseTab()
//     {
//         cg.alpha = 0;
//         cg.interactable = false;
//         cg.blocksRaycasts = false;
//     }

//     public void Purchase()
//     {
//         if(MoneySystem.SubtractMoney(itemBuy.Price))
//             {
//                 Debug.Log(MoneySystem.GetMoney());
//                 itemBuy.inventory.AddItem(itemBuy.item.data,itemBuy.amount);
//             }
//             else
//             {
//                 Debug.Log("No money");
//             }
        
          
        
//     }
// }
