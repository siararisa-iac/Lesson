using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Interactable
{
    public override void Interact()
    {
        Debug.Log("Added a weapon to the inventory");
    }
}
