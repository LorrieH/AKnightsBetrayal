using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDamage : ShopItem, IUpgrade {

    public void Upgrade(PlayerCharacter character)
    {
        character.Damage = character.Damage * 1.1f;
        character.Gold -= _cost; //Reduces the players gold by the cost of the upgrade
    }

    public void DetermineNewCost()
    {
        _cost = _cost / 100 * 110;
    }
}
