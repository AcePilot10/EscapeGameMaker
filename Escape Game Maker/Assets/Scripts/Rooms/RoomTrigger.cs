using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EscapeSceneManager;

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

        public void LoadSubRoom() {
            if (!room.locked) {
                SceneManager sceneManager = GameObject.FindObjectOfType<SceneManager>();
                sceneManager.LoadSubRoom((SubRoom)room);
            }
        }

        public void UnloadSubRoom() {
            SceneManager sceneManager = GameObject.FindObjectOfType<SceneManager>();
            sceneManager.UnloadSubRoom((SubRoom)room);
        }
    }
}