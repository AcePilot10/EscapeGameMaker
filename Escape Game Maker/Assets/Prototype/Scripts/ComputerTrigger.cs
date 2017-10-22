using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;
using UnityEngine.UI;

public class ComputerTrigger : ItemTrigger {

    public override void TakeItem()
    {
        Color color = GetComponent<Image>().color;
        GetComponent<Image>().color = new Color(color.r, color.b, color.g, 255F);
        NotificationManager.instance.MakeNotification("What a nice computer!");
        base.TakeItem();
    }
}
