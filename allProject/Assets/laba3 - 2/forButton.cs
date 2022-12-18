using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class forButton : MonoBehaviour
{
    [SerializeField]
    private GameObject elka;
    public Light lights;

    bool flag;

    public void Some()
    {
        //для изменения текста в кнопке
        var buttonText = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        flag = !flag;
        if (flag == true)
        {
            lights.enabled = true;
            buttonText.text = "выключить";
            Debug.Log("включена елка");
            elka.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.yellow);
        }
        if (flag == false)
        {
            lights.enabled = false;
            buttonText.text = "включить";
            Debug.Log("выключена елка");
            elka.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        }
        
    }
}

