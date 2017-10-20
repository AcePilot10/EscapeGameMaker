using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;
using UnityEngine.UI;

namespace InventorySystem {
    public class InventorySlot : MonoBehaviour
    {
        public bool isEnabled = false;
        private Image image;
        [HideInInspector]public Item item;

        private void Start()
        {
            image = transform.GetChild(0).GetComponent<Image>();
        }

        public void Display(Item item) {
            this.item = item;
            this.isEnabled = true;
            image.sprite = item.icon;
            image.enabled = true;
            Debug.Log("Item has been displayed on: " + image.gameObject.name);
        }

        public void Select() {
            if (isEnabled) {
                if (Inventory.GetInventory().currentlySelected != item)
                {
                    Inventory.GetInventory().SelectItem(this);
                }
            }
        }
    }
}