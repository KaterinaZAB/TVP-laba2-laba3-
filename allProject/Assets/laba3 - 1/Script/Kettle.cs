using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;

namespace Assets
{
    public class Kettle : MonoBehaviour, Interface
    {
        public float distance = 15f;
        GameObject currentWeapon;

        public Transform arm;

        //взять текущий объекта
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

            StartCoroutine(Obzhegsya());
        }
        //выбросить текущий обьект
        public void Drop() 
        {
            currentWeapon.transform.parent = null;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
            currentWeapon = null;
        }

        //корутина задержки объекта на 3 сек
        public IEnumerator Obzhegsya()
        {
            yield return new WaitForSeconds(3f);
            Drop();
        }
    }
}
