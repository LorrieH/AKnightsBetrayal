using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {

    EnemySpawner _enemySpawner;

    [SerializeField]private Transform _enemyParent;
	
    void Start()
    {
        _enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

	void Update () {
        if (_enemyParent.childCount < 1)
        {
            NextWave();
        }
	}

    void NextWave()
    {
        
    }
}
