using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
	PlayerController playerController;
	private int memoryCount;

	private float timer;

	private bool isShowingCutscene1;
	private bool isShowingCutscene2;
	private bool isShowingCutscene3;
	private bool isShowingEnding;

	public GameObject Scene1Image1;
	public GameObject Scene1Image2;
	public GameObject Scene1Image3;
	public GameObject Scene1Image4;

	public GameObject Scene2Image1;
	public GameObject Scene2Image2;
	public GameObject Scene2Image3;
	public GameObject Scene2Image4;

	public GameObject Scene3Image1;
	public GameObject Scene3Image2;
	public GameObject Scene3Image3;
	public GameObject Scene3Image4;

	public GameObject EndImage1;
	public GameObject EndImage2;
	public GameObject EndImage3;
	public GameObject EndImage4;

	public AudioSource memorySound;
	private AudioSource bounceSound;


	// Update is called once per frame
	void Update()
	{
		if (isShowingCutscene1)
		{
			timer += 0.01f;
			if (timer < 1)
			{
				Scene1Image1.SetActive(true);
			}
			else if (timer > 5 && timer < 10)
			{
				Scene1Image1.SetActive(false);
				Scene1Image2.SetActive(true);
			}
			else if (timer > 10 && timer < 15)
			{
				Scene1Image2.SetActive(false);
				Scene1Image3.SetActive(true);
			}
			else if (timer > 15 && timer < 20)
			{
				Scene1Image3.SetActive(false);
				Scene1Image4.SetActive(true);
			}
			else if (timer > 20 && timer < 25)
			{
				Scene1Image4.SetActive(false);
			}
			else if (timer > 25)
			{
				isShowingCutscene1 = false;
				memoryCount += 1;
				print("Memory 1 finished");
			}
		}
		else if (isShowingCutscene2)
		{
			timer += 0.01f;
			if (timer < 5)
			{
				Scene2Image1.SetActive(true);
			}
			else if (timer > 5 && timer < 10)
			{
				Scene2Image1.SetActive(false);
				Scene2Image2.SetActive(true);
			}
			else if (timer > 10 && timer < 15)
			{
				Scene2Image2.SetActive(false);
				Scene2Image3.SetActive(true);
			}
			else if (timer > 15 && timer < 20)
			{
				Scene2Image3.SetActive(false);
				Scene2Image4.SetActive(true);
			}
			else if (timer > 20 && timer < 25)
			{
				Scene2Image4.SetActive(false);
			}
			else if (timer > 25)
			{
				//timer = 0;
				isShowingCutscene2 = false;
				memoryCount += 1;
			}
		}
		else if (isShowingCutscene3)
		{
			timer += 0.01f;

			if (timer < 5)
			{
				Scene3Image1.SetActive(true);
			}
			else if (timer > 5 && timer < 10)
			{
				Scene3Image1.SetActive(false);
				Scene3Image2.SetActive(true);
			}
			else if (timer > 10 && timer < 15)
			{
				Scene3Image2.SetActive(false);
				Scene3Image3.SetActive(true);
			}
			else if (timer > 15 && timer < 20)
			{
				Scene3Image3.SetActive(false);
				Scene3Image4.SetActive(true);
			}
			else if (timer > 20 && timer < 25)
			{
				Scene3Image4.SetActive(false);
				EndImage1.SetActive(true);
			}
			else if (timer > 25 && timer < 30)
			{
				EndImage1.SetActive(false);
				EndImage2.SetActive(true);
			}
			else if (timer > 30 && timer < 35)
			{
				EndImage2.SetActive(false);
				EndImage3.SetActive(true);
			}
			else if (timer > 35 && timer < 40)
			{
				EndImage3.SetActive(false);
				EndImage4.SetActive(true);
			}
			else if (timer > 40 && timer < 45)
			{
				EndImage4.SetActive(false);
			}
			else if (timer > 45)
			{
				//timer = 0;
				isShowingCutscene3 = false;
				SceneManager.LoadScene("RealMenu");
			}
		}
}


void OnCollisionEnter(Collision collision)
{
	if(collision.gameObject.tag == "Enemy")
					SceneManager.LoadScene(SceneManager.GetActiveScene().name);		
}

void OnTriggerEnter(Collider other)
{
		if (other.gameObject.tag == "EnemyAmmo")
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		else if (other.gameObject.tag == "Memory")
		{
			memorySound.Play();
			timer = 0;
			Destroy(other.gameObject);
			ShowCutscene();
		}
		else if (other.gameObject.tag == "Bouncer")
		{
			bounceSound = other.gameObject.transform.parent.gameObject.GetComponent<AudioSource>();
			//bounceSound.Play();
		}
}

private void ShowCutscene()
{
	print(memoryCount);

	if (memoryCount == 0)
		ShowCutscene1();
	else if (memoryCount == 1)
		ShowCutscene2();
	else if (memoryCount == 2)
	{
		ShowCutscene3();
	}
}

private void ShowCutscene1()
{
	isShowingCutscene1 = true;
//
}

private void ShowCutscene2()
{	
	isShowingCutscene2 = true;
//
}

private void ShowCutscene3()
{
	isShowingCutscene3 = true;
}


}
