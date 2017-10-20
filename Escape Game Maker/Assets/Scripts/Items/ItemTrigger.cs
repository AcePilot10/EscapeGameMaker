using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventorySystem;

namespace Items {
    public class ItemTrigger : MonoBehaviour
    {

        public Item item;
        private bool clicked = false;

        public void TakeItem() {
            if (!clicked)
            {
                GetComponent<GAui>().MoveOut();
                clicked = true;
            }
        }

        public void AnimationComplete() {
            Inventory.GetInventory().AddItem(item);
            GameObject.Destroy(gameObject);
        }
    }
}