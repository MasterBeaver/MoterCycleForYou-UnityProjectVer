// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using DG.Tweening;


// public class GuideOpen : MonoBehaviour
// {
//     private bool guideOpenState;
//     public GameObject GuideUI;
//     public GameObject Guide;
    
    
//     void Start()
//     {
//         guideOpenState = false;
//     }

//     void Update()
//     {
      
      
//       if (SearchManeger.Searching == false)
//       {
//         if(Input.GetKeyDown(KeyCode.G))
//            if(guideOpenState == false)
//            {
//              Guide.transform.DOMove(new Vector3(950,550,0),1);
//             //  GuideUI.SetActive(true);
//              guideOpenState = true;
//            }
//            else
//            {
//               Guide.transform.DOMove(new Vector3(950,-450,0),1);
//               // GuideUI.SetActive(false);
//               guideOpenState = false;
//            }
//       }
         

//     }
    
// }
