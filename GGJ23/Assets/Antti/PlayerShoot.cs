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

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerController").GetComponent<Rigidbody>();
        delayTimer = delayTime;
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
        GameObject newAmmo = Instantiate(ammo, new Vector3(transform.position.x + transform.right.x, transform.position.y, transform.position.z + transform.forward.z), gameObject.transform.rotation);
        newAmmo.transform.GetComponent<Rigidbody>().velocity = Player.velocity;
        Destroy(newAmmo, destroyTime);
    }

    
}
