using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rooms;
using InventorySystem;

public class Room2Trigger : RoomTrigger {

    public override void LoadRoom()
    {
        if (room.locked)
        {
            if (Inventory.GetInventory().currentlySelected != null && Inventory.GetInventory().currentlySelected.item.ID == 2)
            {
                room.locked = false;
                NotificationManager.instance.MakeNotification("The room's now unlocked!");
            }
            else
            {
                NotificationManager.instance.MakeNotification("Seems to be locked");
                return;
            }
        }
        else
        {
            RoomManager.GetManager().LoadRoom(room);
        }
    }
}