using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rooms {
    public class RoomManager : MonoBehaviour
    {

        private static RoomManager instance;

        public List<GameObject> rooms;
        public Room currentRoom;
        public GameObject startingRoom;

        private EscapeSceneManager.SceneManager sceneManager;

        public static RoomManager GetManager()
        {
            return instance;
        }

        private void Start()
        {
            instance = this;
            currentRoom = startingRoom.GetComponent<Room>();
            SceneManager.LoadSceneAsync(currentRoom.roomName, LoadSceneMode.Additive);
            sceneManager = GameObject.FindObjectOfType<EscapeSceneManager.SceneManager>();
            //Debug.Log("Initialized Room Manager and loaded starting room.");
        }

        public Room GetRoom(string name)
        {
            foreach (GameObject obj in rooms)
            {
                Room room = obj.GetComponent<Room>();
                if (room.roomName == name)
                {
                    return room;
                }
            }
            return null;
        }

        public void LoadRoom(string name) {
            sceneManager.LoadRoom(name);
        }

        public void LoadRoom(Room room) {
            sceneManager.LoadRoom(room.roomName);
        }
    }
}