using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    [SerializeField]protected float _movementSpeed;
    [SerializeField]protected float _maxHealth;
    [SerializeField]protected float _damage;
    [SerializeField]protected float _attackSpeed;

    protected float _currentHealth;

    public float Health
    {
        get { return _currentHealth; }
        set { _currentHealth = value; }
    }

    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    protected Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _currentHealth = _maxHealth;
    }
}
