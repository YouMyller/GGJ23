using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public enum GameStates { Menu, Main, Cutscene, Pause, Death }
    [HideInInspector]
    public GameStates CurrentGameState;

    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject mainMenu;
	[SerializeField]
	private GameObject mainUI;


	// Start is called before the first frame update
	void Start()
    {
        CurrentGameState = GameStates.Menu;
    }

    // Update is called once per frame
    void Update()
    {
        		//print("How quaint, Time.timeScale is " + Time.timeScale + " over here");
		/*testFloat += .01f;
		print(testFloat);*/
		

		if(CurrentGameState == GameStates.Death)
			GameOverInput();


    }

    public void ChangeGameState(GameStates newGameState)
    {
         CurrentGameState = newGameState;

   	if (CurrentGameState == GameStates.Death)
	{
		Time.timeScale = 0;
		gameOver.SetActive(true);
	}	
	else if(CurrentGameState == GameStates.Menu)
	{
		SceneManager.LoadScene("Menu");
	}
	else if(CurrentGameState == GameStates.Pause)
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0;
	}
	else if (CurrentGameState == GameStates.Main)
	{
		mainMenu.SetActive(false);
		pauseMenu.SetActive(false);
		mainUI.SetActive(true);
		Time.timeScale = 1;
		/*gameOver = GameObject.Find("Canvas/Game Over");
		pauseMenu = GameObject.Find("Canvas/PauseMenu");
		gameOver.SetActive(false);
		pauseMenu.SetActive(false);*/
	}
	else
	{
		//Time.timeScale = 1;
		//DON'T USE TIMESCALE - instead, Player and enemies check game state (if paused, don't do anything)
		gameOver.SetActive(false);
	}
	
    }

   private void GameOverInput()
   {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);		
			ChangeGameState(GameStates.Main);
		}
   }

	
   public void StartGame()
   {
	ChangeGameState(GameStates.Main);
	SceneManager.LoadScene("Main");
   }
    

   public void QuitGame()
   {
	print("QUIT");
	Application.Quit();
   }

   public void ContinueGame()
   {
   	ChangeGameState(GameStates.Main);
   }

   public void Unpause()
  {
	ChangeGameState(GameStates.Main);
  }
}
