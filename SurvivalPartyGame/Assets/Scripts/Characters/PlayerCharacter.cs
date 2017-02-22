using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character {

    protected int _playerID;

    protected int _gold;
    protected int _score;
    protected enum PlayerState
    {
        ALIVE,
        DEAD,
        ENEMY
    }

    protected PlayerState _currentState;

    public int PlayerID
    {
        get { return _playerID; }
        set { _playerID = value; }
    }

    public int Gold
    {
        get { return _gold; }
        set { _gold = value; }
    }

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
}
