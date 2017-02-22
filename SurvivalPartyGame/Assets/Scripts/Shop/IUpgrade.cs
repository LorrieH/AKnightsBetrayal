using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpgrade{

	void Upgrade(PlayerCharacter character);
    void DetermineNewCost();
}
