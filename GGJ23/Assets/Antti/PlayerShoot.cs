using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject ammo;
    public float delayTime;
    public float destroyTime;
    private float delayTimer;
    private Rigidbody Player;
    private Vector3 v3Force;

    public AudioSource pum;

    // Start is called before the first frame update
    void Start()
    {
        delayTimer = delayTime;
        Player = GameObject.Find("PlayerController").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        delayTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftControl) && delayTimer > delayTime){
            delayTimer = 0;
            SpawnAmmo();
        }
    }


    private void SpawnAmmo()
    {
	pum.Play();
	
        //Player.velocity = new Vector3(0, Player.velocity.y, 0);
        v3Force = 50 * transform.forward + Player.velocity;
        GameObject newAmmo = Instantiate(ammo, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        newAmmo.transform.GetComponent<Rigidbody>().velocity = Player.velocity;
        newAmmo.transform.GetComponent<Rigidbody>().AddForce(v3Force);
        Destroy(newAmmo, destroyTime);
    }

    
}
