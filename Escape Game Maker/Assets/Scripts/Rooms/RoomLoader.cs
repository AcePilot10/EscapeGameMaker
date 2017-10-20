using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rooms
{
    public class RoomLoader : MonoBehaviour
    { 

        void Start() {
            Room room = RoomManager.GetManager().GetRoom(gameObject.scene.name);
            room.FindCanvas();      
        }
    }
}