using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class PlayerScript : MonoBehaviour
{
    public float distance = 15f;

    public void StartRay()
    {
        RaycastHit hit;
        Debug.DrawLine(transform.position, -transform.position * 3);

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            //Debug.Log(hit.transform.tag);
            //срабатывает при совпадении тега объекта
            if (hit.transform.tag == "Weapon")
                hit.transform.gameObject.GetComponent<Interface>().PickUp(hit);
        }
    }
    void Update()
    {
        //по нажатию клавиши E запускаем метод 
        if (Input.GetKeyDown(KeyCode.E)) StartRay();
    }
}
