using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class RoomBuilder : MonoBehaviour, IRoomBuilder
    {
        [SerializeField]
        //список всей доступной мебели
        public List<GameObject> allMebel;
        //инициализация словаря префабов мебели
        public Dictionary<string, GameObject> prefabs; 
        public void Awake()
        {
            room = new Room();
            prefabs = new Dictionary<string, GameObject>();
            prefabs.Add("диван", allMebel[0]);
            prefabs.Add("кресло", allMebel[1]);
            prefabs.Add("стол", allMebel[2]);
            prefabs.Add("стул", allMebel[3]);
            prefabs.Add("ковёр", allMebel[4]);
            prefabs.Add("тв", allMebel[5]);
            prefabs.Add("шкаф", allMebel[6]);
        }
        public Room room;
        public void BuildArmChair()
        {
            room.mebelz.Add("кресло", prefabs["кресло"]);
        }

        public void BuildCarpet()
        {
            room.mebelz.Add("ковёр", prefabs["ковёр"]);
        }

        public void BuildChair()
        {
            room.mebelz.Add("стул", prefabs["стул"]);
        }

        public void BuildCupboard()
        {
            room.mebelz.Add("шкаф", prefabs["шкаф"]);
        }

        public void BuildSofa()
        {
            room.mebelz.Add("диван", prefabs["диван"]);
        }

        public void BuildTv()
        {
            room.mebelz.Add("тв", prefabs["тв"]);
        }
        public void BuildTable()
        {
            room.mebelz.Add("стол", prefabs["стол"]);
        }

        public Room GetRoom()
        {
            return room;
        }
    }
}
