using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject ammo;
    public GameObject SpawnPoint;
    public float destroyTime;
    private float timer;
    private bool canShoot;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > fireRate)
        {
            canShoot = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && canShoot == true)
        {
            ShootingStart();
            timer = 0;
            canShoot = false;
        }
    }


    private void ShootingStart()
    {
        GameObject newAmmo = Instantiate(ammo, SpawnPoint.transform.position, gameObject.transform.rotation);
        Destroy(newAmmo, destroyTime);
    }
}
