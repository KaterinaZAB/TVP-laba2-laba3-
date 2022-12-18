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
    public Text menu; //��� ������ ����������� ������

    public void Start()
    {
        // �������� ��-� ����� ��� ���������� � ������� ������
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
        //��� ������� S ��������� ������
        if (Input.GetKeyDown(KeyCode.S))
        {
            InsertMebel();
        }
    }
    //����� ��� ������� ������
    void InsertMebel()
    {
        var drop = GameObject.FindGameObjectWithTag("drop");
        var dropdown = drop.GetComponent<TMP_Dropdown>();
        //��������� ������� �����
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 pos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(room.mebelz[dropdown.options[dropdown.value].text], pos, Quaternion.identity);
    }
}
