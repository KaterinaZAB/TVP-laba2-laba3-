using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

namespace Assets
{
    public class Mebel : MonoBehaviour
    {
        public RoomBuilder roomBuilder;
        public Room CreateRoom()
        {
            roomBuilder.BuildSofa();
            roomBuilder.BuildCupboard();
            roomBuilder.BuildTv();
            roomBuilder.BuildTable();
            roomBuilder.BuildChair();
            roomBuilder.BuildArmChair();
            roomBuilder.BuildCarpet();
            var newRoom = roomBuilder.GetRoom();

            return newRoom;
        }
        public void Start()
        {
            //CreateRoom();
        }
    }
    
}
