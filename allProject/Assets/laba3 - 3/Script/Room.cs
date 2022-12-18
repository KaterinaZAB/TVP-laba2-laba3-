using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Room
    {
        //создание словаря предметов мебели
        public Dictionary<string, GameObject> mebelz;
        public Room()
        {
            mebelz = new Dictionary<string, GameObject>();
        }
    }
}
