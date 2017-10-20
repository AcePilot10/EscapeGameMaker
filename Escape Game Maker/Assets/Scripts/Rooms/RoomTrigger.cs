using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rooms {
    public class RoomTrigger : MonoBehaviour
    {

        public Room room;

        public void LoadRoom()
        {
            if (!room.locked) {
                RoomManager.GetManager().LoadRoom(room);
                Debug.Log("Loaded room: " + room.roomName);
            }
        }
    }
}