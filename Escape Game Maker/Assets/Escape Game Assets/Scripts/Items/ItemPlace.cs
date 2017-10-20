using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventorySystem;
using UnityEngine.UI;

namespace Items {
    public class ItemPlace : MonoBehaviour
    {

        public Item item;
        private Image img;
        public bool used = false;

        private void Start()
        {
            img = GetComponent<Image>();
        }

        public void PlaceItem() {
            if (!used)
            {
                if (Inventory.GetInventory().currentlySelected.item.ID == item.ID)
                {
                    img.sprite = item.icon;
                    used = true;
                }
            }
            else {
                GetComponent<PlacedItemInteractable>().Interact();
            }
        }

        public void SetUsed(bool used) {
            this.used = used;
        }

        public bool Used() { return used; }
    }
}
