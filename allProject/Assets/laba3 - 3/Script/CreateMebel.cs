using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets;

public class CreateMebel : MonoBehaviour
{
    public Mebel mebel;
    private Room room;
    public Text menu; //для текста выпадающего списка

    public void Start()
    {
        // получаем эл-т дропд для добавления в словарь мебели
        var drop = GameObject.FindGameObjectWithTag("drop");
        var dropdown = drop.GetComponent<TMP_Dropdown>();
        room = mebel.CreateRoom();
        foreach (var m in room.mebelz)
        {
            TMP_Dropdown.OptionData optionData = new TMP_Dropdown.OptionData(m.Key);
            dropdown.options.Add(optionData);
            dropdown.RefreshShownValue();
        }
    }

    private void Update()
    {
        //при нажатии S добавляем пример
        if (Input.GetKeyDown(KeyCode.S))
        {
            InsertMebel();
        }
    }
    //метод для вставки мебели
    void InsertMebel()
    {
        var drop = GameObject.FindGameObjectWithTag("drop");
        var dropdown = drop.GetComponent<TMP_Dropdown>();
        //получение позиции мышки
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 pos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(room.mebelz[dropdown.options[dropdown.value].text], pos, Quaternion.identity);
    }
}
