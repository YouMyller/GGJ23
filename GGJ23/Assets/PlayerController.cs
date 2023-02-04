using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Die()
    {
        GameManager.ChangeGameState(GameManager.GameStates.Death);
        //TODO: 
        //Create death UI element
        //in game manager change state function: pause gameplay, show death UI
        //element, reset scene
        //Also checkpoints would be nice :)
    }

    public void Pause()
    {
        GameManager.ChangeGameState(GameManager.GameStates.Pause);
        print("Pause");
        //TODO: 
        //Create pause menu elements
        //in game manager change state function: pause gameplay, show menu elements
    }

    public void GoToMain()
    {
        GameManager.ChangeGameState(GameManager.GameStates.Main);
        //TODO: 
        //Create main gameplay scene
        //in game manager change state function: change scene to main
    }

    public void StartCutscene()
    {
        GameManager.ChangeGameState(GameManager.GameStates.Cutscene);
        //TODO: 
        //Create cutscene template
        //in game manager change state function: pause gameplay, show cutscene
    }

    public void GoToMenu()
    {
        GameManager.ChangeGameState(GameManager.GameStates.Menu);
        //TODO: 
        //Create main menu scene
        //in game manager change state function: change scene to menu
    }
}
