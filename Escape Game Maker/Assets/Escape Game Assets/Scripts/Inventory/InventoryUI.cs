using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Items;

namespace InventorySystem {
    public class InventoryUI : MonoBehaviour {

        private static InventoryUI instance;

        public Transform slots;

        public static InventoryUI Get() {
            return instance;
        }

        void Start() {
            instance = this;
        }

        public void DisplayItem(Item item) {
            foreach (Transform child in slots) {
                InventorySlot slot = child.GetComponent<InventorySlot>();
                if (!slot.isEnabled) {
                    slot.item = item;
                    slot.Display(item);
                    //Debug.Log("Displaying item with unique ID of: " + item.ID);
                    break;
                }
            }
        }
    }
}