
using UnityEngine;
using TMPro;

public class SearchManeger : MonoBehaviour
{
    public static bool Searching;
    
    public GameObject ContentHolder;

    public GameObject[] Element;

    public GameObject SeacrhBar;

    public int totalElement;

    void Start()
    {
        Searching = false;

        totalElement = ContentHolder.transform.childCount;

        Element = new GameObject[totalElement];

        for (int i = 0; i < totalElement; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
    }

    public void Search()
    {
        string SearchText = SeacrhBar.GetComponent<TMP_InputField>().text;
        int searchTextLength = SearchText.Length;

        int searchedElement = 0;

        foreach (GameObject ele in Element)
        {
            Searching = true;

            searchedElement += 1;

            if(ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Length >= searchTextLength)
            {
                if(SearchText.ToLower() == ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Substring(0,searchTextLength).ToLower())
                {
                    ele.SetActive(true);
                }
                else
                {
                    ele.SetActive(false);
                }
            }
        }
    }

    public void EndSearch()
    {
        Searching = false;
    }
}    
