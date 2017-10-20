using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rooms {
    public class CurrentRoomUI : MonoBehaviour
    {

        private Text text;

        private void Start()
        {
            text = GetComponent<Text>();
        }

        private void Update()
        {
            string currentRoom = RoomManager.GetManager().currentRoom.roomName;
            text.text = currentRoom;
        }
    }
}