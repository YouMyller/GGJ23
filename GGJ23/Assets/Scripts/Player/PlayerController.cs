using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
        /*else if (Input.GetKey(KeyCode.Space))
            GoToMenu();*/

            //Die();
    }

    public void Die()
    {
        gameManager.ChangeGameState(GameManager.GameStates.Death);
        //TODO: 
        //in game manager change state function: checkpoints would be nice :)
    }

    public void GoToMenu()
    {
        gameManager.ChangeGameState(GameManager.GameStates.Menu);
    }

    public void Pause()
    {
        gameManager.ChangeGameState(GameManager.GameStates.Pause);
        print("Pause");
        //TODO: 
        //Create pause menu elements
        //in game manager change state function: pause gameplay, show menu elements
    }

    public void StartCutscene()
    {
        gameManager.ChangeGameState(GameManager.GameStates.Cutscene);
        //TODO: 
        //Create cutscene template
        //in game manager change state function: pause gameplay, show cutscene
    }

    public void GoToMain()
    {
        gameManager.ChangeGameState(GameManager.GameStates.Main);
        //TODO: 
        //Create main gameplay scene
        //in game manager change state function: change scene to main
    }

}
