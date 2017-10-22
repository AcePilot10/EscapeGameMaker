using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

public class PlacedMoniterInteractable : PlacedItemInteractable {

    public override void Interact()
    {
        NotificationManager.instance.MakeNotification("You have interacted with the moniter!");
    }
}