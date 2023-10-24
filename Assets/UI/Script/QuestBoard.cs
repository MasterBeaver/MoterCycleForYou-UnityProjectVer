using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard : MonoBehaviour
{
    public CanvasGroup QBoard;
    public CanvasGroup press;
    public bool condition = false;
    bool check;
    public KeyCode Key = KeyCode.E;
    public Animator Fade;

    void Start()
    {
        QBoardStatus(false, 0);
        pressStatus(false, 0);
    }
    
    
    public void pressStatus(bool status, float num)
    {
        press.alpha = num;
        press.blocksRaycasts = status;
        press.interactable = status;
    }

    public void QBoardStatus(bool status, float num)
    {
        QBoard.alpha = num;
        QBoard.blocksRaycasts = status;
        QBoard.interactable = status;
    }
    
    public void QBoardClose()
    {
        QBoardStatus(false, 0);
        check = true;
        
    }

    public void AcceptQuest()
    {
        Fade.SetTrigger("Fade");
        StartCoroutine(ChangeScene());
    }
    
    IEnumerator ChangeScene()
    {
        
        yield return new WaitForSeconds(1.5f);
        Debug.Log("change");

    }


    void Update()
    {
        // Debug.Log(QBoard.alpha);
         if(condition == true && check == true)
        {
            pressStatus(true, 1);
        }
        else
        {
            pressStatus(false, 0);
        }

        if(condition == true)
        {
             if(Input.GetKeyDown(Key))
             {
                QBoardStatus(true, 1);
                check = false;
             }
        }
    }
}
