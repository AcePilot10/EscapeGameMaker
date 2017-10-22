using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rooms;

namespace EscapeSceneManager
{
    public class SceneManager : MonoBehaviour
    {

        public void LoadRoom(string name)
        {
            try
            {
                string currentRoom = RoomManager.GetManager().currentRoom.roomName;
                Room room = RoomManager.GetManager().GetRoom(name);
                bool loaded = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name).isLoaded;
                if (!loaded)
                {
                    UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
                    Debug.Log("Loaded: " + name);
                }

                RoomManager.GetManager().currentRoom.canvas.SetActive(false);
                room.canvas.SetActive(true);
                RoomManager.GetManager().currentRoom = room;
            }
            catch (System.Exception ex) {
              //  Debug.Log("Error while loading room: " + ex);
            }
        }

        public void LoadSubRoom(SubRoom room) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(room.roomName, LoadSceneMode.Additive);
        }

        public void UnloadSubRoom(SubRoom room) {
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(room.roomName);
        }
    }
}