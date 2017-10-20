using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {
    [RequireComponent(typeof(ItemPlace))]
    public class PlacedItemInteractable : MonoBehaviour
    {

        private bool used = false;

        public void Interact() {
            if (!used)
            {
                OnInteract();
                used = true;
            }
        }

        protected virtual void OnInteract() { }

    }
}