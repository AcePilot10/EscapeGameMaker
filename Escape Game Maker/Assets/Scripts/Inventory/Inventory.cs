using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

namespace InventorySystem {
    public class Inventory : MonoBehaviour
    {

        private static Inventory instance;

        public List<Item> items = new List<Item>();

        public InventorySlot currentlySelected = null;

        public static Inventory GetInventory()
        {
            return instance;
        }

        void Start()
        {
            instance = this;
        }

        public bool HasItem(int id) {
            foreach (Item item in items) {
                if (item.ID == id) {
                    return true;
                }
            }
            return false;
        }

        public Item GetItem(int id)
        {
            if (HasItem(id))
            {
                foreach (Item item in items)
                {
                    if (item.ID == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            InventoryUI.Get().DisplayItem(item);
        }

        public void RemoveItem(int id) {
            if (HasItem(id)) {
                items.Remove(GetItem(id));
            }
        }

        public void SelectItem(InventorySlot slot) {
            if (currentlySelected != null) {
                currentlySelected.GetComponent<GAui>().MoveOut();
                Debug.Log("Moving out item slot with item: " + currentlySelected.item.ID);
            }
            currentlySelected = slot;
            slot.gameObject.GetComponent<GAui>().MoveIn();
            Debug.Log("Selected item: " + slot.item.ID);
        }
    }
}