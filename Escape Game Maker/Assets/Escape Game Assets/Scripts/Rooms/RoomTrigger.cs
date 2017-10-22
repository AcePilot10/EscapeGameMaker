using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EscapeSceneManager;

namespace Rooms {
    public class RoomTrigger : MonoBehaviour
    {

        protected Room room;
        public string roomName;

        private void Start()
        {
            room = RoomManager.GetManager().GetRoom(roomName);
        }

        public virtual void LoadRoom()
        {
            if (!room.locked) {
                RoomManager.GetManager().LoadRoom(room);
              //  Debug.Log("Loaded room: " + room.roomName);
            }
        }

        public virtual void LoadSubRoom() {
            if (!room.locked) {
                SceneManager sceneManager = GameObject.FindObjectOfType<SceneManager>();
                sceneManager.LoadSubRoom((SubRoom)room);
            }
        }

        public virtual void UnloadSubRoom() {
            SceneManager sceneManager = GameObject.FindObjectOfType<SceneManager>();
            sceneManager.UnloadSubRoom((SubRoom)room);
        }
    }
}