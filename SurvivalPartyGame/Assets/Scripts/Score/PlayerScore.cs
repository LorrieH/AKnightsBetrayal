using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddScore(PlayerCharacter player,int scoreToAdd)
    {
        player.Score += scoreToAdd;
    }

    void ReduceScore(PlayerCharacter player, int scoreToReduce)
    {
        player.Score -= scoreToReduce;
    }
}
