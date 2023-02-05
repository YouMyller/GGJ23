using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    
    public float forceAmount;
    private Vector3 v3Force;
    private Rigidbody Player;

    public AudioSource hitSound;
    private AudioSource monsterDeathSound;

    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("PlayerController").GetComponent<Rigidbody>();
        v3Force = forceAmount * Player.transform.forward + Player.velocity;

	monsterDeathSound = GameObject.Find("MonsterDeathAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         rb.AddForce(v3Force * Time.deltaTime, ForceMode.Acceleration);
    }

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
{
	    hitSound.Play();
	    monsterDeathSound.Play();

            Destroy(other.gameObject);
	    Destroy(this.gameObject);
}

        /*if (other.gameObject.tag != "Player" || other.gameObject.tag != "JumpTrigger" || other.gameObject.tag != "PlayerFeet")
        {
            print("I die");
            Destroy(this);
        }*/
    }
}
