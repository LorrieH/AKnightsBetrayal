using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {

    private EnemySpawner _enemySpawner;

    void Start()
    {
        _enemySpawner = GameObject.FindGameObjectWithTag(Tags.ENEMYSPAWNER).GetComponent<EnemySpawner>();
    }

    void Death()
    {
        _animator.SetBool("isDead",true);
        _enemySpawner.
    }
}
