using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventorySystem;

namespace Items {
    public class ItemTrigger : MonoBehaviour
    {

        private Item item;
        private bool clicked = false;
        public int id;

        private void Start()
        {
            item = Inventory.GetInventory().GetItemFromAll(id);
        }

        public virtual void TakeItem()
        {
            if (!clicked)
            {
                GetComponent<GAui>().MoveOut();
                clicked = true;
            }
            else return;
        }

        public void AnimationComplete()
        {
            Inventory.GetInventory().AddItem(item);
            GameObject.Destroy(gameObject);
        }

        public Item GetItem()
        {
            return this.item;
        }
    }
}