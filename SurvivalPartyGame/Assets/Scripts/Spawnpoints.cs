using System.Collections;//( ͡° ͜ʖ ͡°)
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour {

    private List<GameObject> _spawnpoints = new List<GameObject>();

    void Awake()
    {
        foreach (Transform child in transform)
        {
            _spawnpoints.Add(child.gameObject);
        }
    }
}
