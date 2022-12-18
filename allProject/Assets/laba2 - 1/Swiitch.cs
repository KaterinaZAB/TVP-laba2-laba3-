using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swiitch : MonoBehaviour
{
    public GameObject[] background;
    public Button next;
    public Button prev;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (index > 0 && index < 4)
        {
            //кнопка активна
            prev.interactable = true;
            next.interactable = true;
        }
        if (index > 4) index = 4;
        if (index < 0) index = 0;

        if (index == 0)
        {
            background[0].gameObject.SetActive(true);
            prev.interactable = false; //кнопка не активна
        }
        if (index == 4) next.interactable = false; //кнопка не активна

    }
    //реализация кнопки далее
    public void Next()
    {
        index += 1;
        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
    //реализация кнопки назад
    public void Previous()
    {
        index -= 1;
        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
