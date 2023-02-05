using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	private float timer;

	private bool isShowingIntro;

	public GameObject IntroImage1;
	public GameObject IntroImage2;
	public GameObject IntroImage3;
	public GameObject IntroImage4;
	public GameObject IntroImage5;
	public GameObject IntroImage6;
	public GameObject IntroImage7;
	public GameObject IntroImage8;
	public GameObject IntroImage9;
	public GameObject IntroImage10;
	public GameObject IntroImage11;
	public GameObject IntroImage12;
	public GameObject IntroImage13;
	public GameObject IntroImage14;
	public GameObject IntroImage15;
	public GameObject IntroImage16;
	public GameObject IntroImage17;
	public GameObject IntroImage18;
	public GameObject IntroImage19;
	public GameObject IntroImage20;


 private void Update()
{
	if (isShowingIntro)
		{
			timer += 0.01f;
			if (timer < 5)
			{
				IntroImage1.SetActive(true);
			}
			else if (timer > 5 && timer < 10)
			{
				IntroImage1.SetActive(false);
				IntroImage2.SetActive(true);
			}
			else if (timer > 10 && timer < 15)
			{
				IntroImage2.SetActive(false);
				IntroImage3.SetActive(true);
			}
			else if (timer > 15 && timer < 20)
			{
				IntroImage3.SetActive(false);
				IntroImage4.SetActive(true);
			}
			else if (timer > 20 && timer < 25)
			{
				IntroImage4.SetActive(false);
				IntroImage5.SetActive(true);
			}
			else if (timer > 25 && timer < 30)
			{
				IntroImage5.SetActive(false);
				IntroImage6.SetActive(true);
			}
			else if (timer > 30 && timer < 35)
			{
				IntroImage6.SetActive(false);
				IntroImage7.SetActive(true);
			}
			else if (timer > 35 && timer < 40)
			{
				IntroImage7.SetActive(false);
				IntroImage8.SetActive(true);
			}
			else if (timer > 40 && timer < 45)
			{
				IntroImage8.SetActive(false);
				IntroImage9.SetActive(true);
			}
			else if (timer > 45 && timer < 50)
			{
				IntroImage9.SetActive(false);
				IntroImage10.SetActive(true);
			}
			else if (timer > 50 && timer < 55)
			{
				IntroImage10.SetActive(false);
				IntroImage11.SetActive(true);
			}
			else if (timer > 55 && timer < 60)
			{
				IntroImage11.SetActive(false);
				IntroImage12.SetActive(true);
			}
			else if (timer > 60 && timer < 65)
			{
				IntroImage12.SetActive(false);
				IntroImage13.SetActive(true);
			}
			else if (timer > 65 && timer < 70)
			{
				IntroImage13.SetActive(false);
				IntroImage14.SetActive(true);
			}
			else if (timer > 70 && timer < 75)
			{
				IntroImage14.SetActive(false);
				IntroImage15.SetActive(true);
			}
			else if (timer > 75 && timer < 80)
			{
				IntroImage15.SetActive(false);
				IntroImage16.SetActive(true);
			}
			else if (timer > 80 && timer < 85)
			{
				IntroImage16.SetActive(false);
				IntroImage17.SetActive(true);
			}
			else if (timer > 85 && timer < 90)
			{
				IntroImage17.SetActive(false);
				IntroImage18.SetActive(true);
			}
			else if (timer > 90 && timer < 95)
			{
				IntroImage18.SetActive(false);
				IntroImage19.SetActive(true);
			}
			else if (timer > 95 && timer < 100)
			{
				IntroImage19.SetActive(false);
				IntroImage20.SetActive(true);
			}
			else if (timer > 100 && timer < 105)
			{
				IntroImage20.SetActive(false);
				StartGame();
			}
		}
}

    public void StartCutscene()
{
	isShowingIntro = true;
}

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


   
}
