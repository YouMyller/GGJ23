using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public enum GameStates { Menu, Main, Cutscene, Pause, Death }
    GameStates CurrentGameState;

    [SerializeField]
    private GameObject GameOver;


    float testFloat = 0;

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
		GameOver.SetActive(true);
	}	
	else if(CurrentGameState == GameStates.Menu)
	{
		SceneManager.LoadScene("Menu");
	}
	else
	{
		Time.timeScale = 1;
		GameOver.SetActive(false);
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
	SceneManager.LoadScene("Main");
   }
    

   public void QuitGame()
   {
	print("QUIT");
	Application.Quit();
   }
}
