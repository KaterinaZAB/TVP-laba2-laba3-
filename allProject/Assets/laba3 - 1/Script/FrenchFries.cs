using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditorInternal;
using UnityEngine.UI;

namespace Assets
{
    public class FrenchFries : MonoBehaviour, Interface
    {
        int health = 10;

        public float distance = 15f;
        GameObject currentWeapon;

        public void PickUp(RaycastHit hit)
        {
            Rigidbody myRigidBody = gameObject.GetComponent<Rigidbody>();
            currentWeapon = hit.transform.gameObject;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
            currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);

            Debug.Log("ваше здоровье:" + health);
            health = health + 100;
            Debug.Log("вы повысили здоровье! теперь у Вас:" + health);

            Destroy(hit.transform.gameObject);

        }
        public void Drop() { }
        public void destroy()
        {
            Destroy(gameObject);
        }
    }
}
