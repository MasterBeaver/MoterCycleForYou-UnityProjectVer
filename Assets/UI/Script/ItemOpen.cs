// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;
// using UnityEngine.EventSystems;


// public class ItemOpen : MonoBehaviour
// {
//     [SerializeField] private GameObject obj;
//     // [SerializeField] private BuyTab cgBuy;
//     [SerializeField] private CanvasGroup cg;
//     [Header("Input")]
//     [SerializeField] private TextMeshProUGUI Des;
//     public int Price;
    
//     [Header("Output")]
//     [SerializeField] private TextMeshProUGUI NameText;
//     [SerializeField] private TextMeshProUGUI DesText;
//     [SerializeField] private TextMeshProUGUI PriceText;
//     private GameObject image;

//     [Header("Inventory")]
//     // public InventorySystem inventory;
//     // public Item item;
//     public int amount;
    
   
//     void Start()
//     {
//         image = GameObject.FindGameObjectWithTag("ShopPopup");
//         cg = image.GetComponent<CanvasGroup>();
//         cgBuy = image.GetComponent<BuyTab>();
//         NameText = image.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
//         DesText = image.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
//         PriceText = image.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
//     }
    
//     public void OpenTab()
//     {
//         cg.transform.position = obj.transform.position + new Vector3(220,0,0);
//         cg.alpha = 1;
//         cg.interactable = true;
//         cg.blocksRaycasts = true;
        

//         NameText.text = obj.name;
//         DesText.text = Des.text;
//         PriceText.text = Price.ToString();
//         cgBuy.itemBuy = this;

//     }

    
   
// }
