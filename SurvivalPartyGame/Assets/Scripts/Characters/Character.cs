using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    [SerializeField]protected float _movementSpeed;
    [SerializeField]protected float _health;
    [SerializeField]protected float _damage;
    [SerializeField]protected float _attackSpeed;

    public float Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
}
