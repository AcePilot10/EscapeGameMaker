using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

public class KeyTrigger : ItemTrigger {

    public override void TakeItem()
    {
        NotificationManager.instance.MakeNotification("I can unlock that door with this!");
        base.TakeItem();
    }

}