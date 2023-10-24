using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOpen : MonoBehaviour
{
    public QuestBoard questBoard;
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            questBoard.condition = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            questBoard.condition = false;
        }
    }
}
