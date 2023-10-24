using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gas : MonoBehaviour
{
    public TMP_InputField g91;
    public TMP_InputField g95;
    public TMP_InputField g95E20;
    
    public static float Gas91;
    public static float Gas95;
    public static float GasE20;

    void Start()
    {
        Gas91 = PlayerPrefs.GetFloat("Gas91");
        Gas95 = PlayerPrefs.GetFloat("Gas95");
        GasE20 = PlayerPrefs.GetFloat("GasE20");

        g91.text = Gas91.ToString();
        g95.text = Gas95.ToString();
        g95E20.text = GasE20.ToString();

    }
    
    public void Confirm()
    {
       PlayerPrefs.SetFloat("Gas91",float.Parse(g91.text));
       PlayerPrefs.SetFloat("Gas95",float.Parse(g95.text));
       PlayerPrefs.SetFloat("GasE20",float.Parse(g95E20.text));

       Gas91 = PlayerPrefs.GetFloat("Gas91");
       Gas95 = PlayerPrefs.GetFloat("Gas95");
       GasE20 = PlayerPrefs.GetFloat("GasE20");
    }
}
