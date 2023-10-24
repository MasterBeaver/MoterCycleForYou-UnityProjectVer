using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class Hover : MonoBehaviour
{
    private CanvasGroup cg;
    [SerializeField]
    private TextMeshProUGUI infoText;
    // [SerializeField]
    // private float xPos = 0;
    
    private void OnEnable()
    {
        HoverUI.onPointerEnter += DisplayInfo;
        HoverUI.onPointerExit += CloseWindow;

        cg = this.GetComponent<CanvasGroup>();
    }
    
    private void OnDisable() 
    {
        HoverUI.onPointerEnter -= DisplayInfo;
        HoverUI.onPointerExit -= CloseWindow;
    }

    private void CloseWindow(GameObject obj)
    {
        cg.alpha = 0;
    }

    private void DisplayInfo(GameObject hoverObject, PointerEventData pointerData)
    {
        this.transform.position = pointerData.position + new Vector2(170, 0);

        cg.alpha = 1;

        infoText.text = hoverObject.name;
    }
}

