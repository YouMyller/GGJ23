using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	private float timer;

	private bool isShowingIntro;

  	public AudioSource laulu;

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
			else if (timer > 4 && timer < 8)
			{
				IntroImage1.SetActive(false);
				IntroImage2.SetActive(true);
			}
			else if (timer > 8 && timer < 12)
			{
				IntroImage2.SetActive(false);
				IntroImage3.SetActive(true);
			}
			else if (timer > 12 && timer < 16)
			{
				IntroImage3.SetActive(false);
				IntroImage4.SetActive(true);
			}
			else if (timer > 16 && timer < 20)
			{
				IntroImage4.SetActive(false);
				IntroImage5.SetActive(true);
			}
			else if (timer > 20 && timer < 24)
			{
				IntroImage5.SetActive(false);
				IntroImage6.SetActive(true);
			}
			else if (timer > 24 && timer < 28)
			{
				IntroImage6.SetActive(false);
				IntroImage7.SetActive(true);
			}
			else if (timer > 28 && timer < 32)
			{
				IntroImage7.SetActive(false);
				IntroImage8.SetActive(true);
			}
			else if (timer > 32 && timer < 36)
			{
				IntroImage8.SetActive(false);
				IntroImage9.SetActive(true);
			}
			else if (timer > 36 && timer < 40)
			{
				IntroImage9.SetActive(false);
				IntroImage10.SetActive(true);
			}
			else if (timer > 40 && timer < 44)
			{
				IntroImage10.SetActive(false);
				IntroImage11.SetActive(true);
			}
			else if (timer > 44 && timer < 48)
			{
				IntroImage11.SetActive(false);
				IntroImage12.SetActive(true);
			}
			else if (timer > 48 && timer < 52)
			{
				IntroImage12.SetActive(false);
				IntroImage13.SetActive(true);
			}
			else if (timer > 52 && timer < 56)
			{
				IntroImage13.SetActive(false);
				IntroImage14.SetActive(true);
			}
			else if (timer > 56 && timer < 60)
			{
				IntroImage14.SetActive(false);
				IntroImage15.SetActive(true);
			}
			else if (timer > 60 && timer < 64)
			{
				IntroImage15.SetActive(false);
				IntroImage16.SetActive(true);
			}
			else if (timer > 64 && timer < 68)
			{
				IntroImage16.SetActive(false);
				IntroImage17.SetActive(true);
			}
			else if (timer > 68 && timer < 72)
			{
				IntroImage17.SetActive(false);
				IntroImage18.SetActive(true);
			}
			else if (timer > 72 && timer < 76)
			{
				IntroImage18.SetActive(false);
				IntroImage19.SetActive(true);
			}
			else if (timer > 76 && timer < 80)
			{
				IntroImage19.SetActive(false);
				IntroImage20.SetActive(true);
			}
			else if (timer > 80 && timer < 84)
			{
				IntroImage20.SetActive(false);
				StartGame();
			}
		}
}

    public void StartCutscene()
{
	laulu.Play();
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
