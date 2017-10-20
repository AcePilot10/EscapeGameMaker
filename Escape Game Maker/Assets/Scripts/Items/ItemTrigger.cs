using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventorySystem;

namespace Items {
    public class ItemTrigger : MonoBehaviour
    {

        public Item item;

        public void TakeItem() {
            Inventory.GetInventory().AddItem(item);
            GameObject.Destroy(gameObject);
        }
    }
}