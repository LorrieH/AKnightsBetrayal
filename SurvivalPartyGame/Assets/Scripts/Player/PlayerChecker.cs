using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour {

    [SerializeField]private List<GameObject> _players = new List<GameObject>();
	// Use this for initialization
	void Start () {
        AddPlayers();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddPlayers()
    {
        foreach (GameObject player in GameObject.FindGameObjectsWithTag(Tags.PLAYER))
        {
            _players.Add(player);
        }
    }
}
