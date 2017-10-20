using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rooms {
    public class Room : MonoBehaviour
    {

        public string roomName;
        public bool locked = false;
        public GameObject canvas;

        public void FindCanvas() {
            GameObject[] canvases = GameObject.FindGameObjectsWithTag("Canvas");
            foreach (GameObject obj in canvases) {
                if (obj.scene.name == roomName) {
                    canvas = obj;
                    Debug.Log("Initialized canvas for: " + roomName);
                    break;
                }
            }
        }
    }
}
