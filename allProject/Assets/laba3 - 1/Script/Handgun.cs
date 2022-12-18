using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    //класс для пистолета
    class Handgun : MonoBehaviour, Interface
    {
        public float distance = 15f;
        GameObject currentWeapon; //текущий объект
        public Transform arm;

        public void PickUp(RaycastHit hit)
        {
            Rigidbody myRigidBody = gameObject.GetComponent<Rigidbody>();
            currentWeapon = hit.transform.gameObject;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
            currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);

            transform.SetParent(arm);
            //принятие его позиции
            transform.position = arm.position;
            transform.rotation = arm.rotation;
            myRigidBody.isKinematic = true;
        }
        public void Drop() //выбросить текущий обьект
        {
            currentWeapon.transform.parent = null;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
            currentWeapon = null;
        }
    }
}
