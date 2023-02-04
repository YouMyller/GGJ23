using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public enum GameStates { Menu, Main, Cutscene, Pause, Death }
    GameStates CurrentGameState;

    // Start is called before the first frame update
    void Start()
    {
        CurrentGameState = GameStates.Menu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGameState(GameStates newGameState)
    {
        CurrentGameState = newGameState;
    }
}
