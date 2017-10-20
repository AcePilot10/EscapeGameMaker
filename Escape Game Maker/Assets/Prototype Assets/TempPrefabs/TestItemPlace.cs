using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

public class TestItemPlace : PlacedItemInteractable {

    protected override void OnInteract()
    {
        base.OnInteract();
        Debug.Log("Test item  has been interacted with!");
    }
}