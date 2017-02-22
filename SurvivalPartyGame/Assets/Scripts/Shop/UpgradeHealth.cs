using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHealth : ShopItem, IUpgrade {

    public void Upgrade(PlayerCharacter character)
    {
        //character.Health = character.Health + ()
        character.Gold -= _cost;
    }

    public void DetermineNewCost()
    {

    }
}
