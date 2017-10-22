using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

namespace InventorySystem {
    public class Inventory : MonoBehaviour
    {

        private static Inventory instance;

        private List<Item> items = new List<Item>();

        public List<Item> allItems;

        public InventorySlot currentlySelected = null;

        private Vector3 normalSlotSize;

        public static Inventory GetInventory()
        {
            return instance;
        }

        void Start()
        {
            instance = this;
            normalSlotSize = InventoryUI.Get().slots.GetChild(0).transform.localScale;
        }

        public bool HasItem(int id) {
            foreach (Item item in items) {
                if (item.ID == id) {
                    return true;
                }
            }
            return false;
        }

        public Item GetItemFromInventory(int id)
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

        public Item GetItemFromAll(int id) {
            foreach (Item item in allItems) {
                if (item.ID == id) {
                    return item;
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
                items.Remove(GetItemFromInventory(id));
            }
        }

        public void SelectItem(InventorySlot slot) {
            if (currentlySelected != null) {
                currentlySelected.GetComponent<GAui>().MoveOut();
                currentlySelected.gameObject.transform.localScale = normalSlotSize;
                // Debug.Log("Moving out item slot with item: " + currentlySelected.item.ID);
                if (currentlySelected == slot) {
                    currentlySelected = null;
                    return;
                }
            }
            currentlySelected = slot;
            slot.gameObject.GetComponent<GAui>().MoveIn();
           // Debug.Log("Selected item: " + slot.item.ID);
        }
    }
}