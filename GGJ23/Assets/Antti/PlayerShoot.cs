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
    

    // Start is called before the first frame update
    void Start()
    {
        delayTimer = delayTime;
    }

    // Update is called once per frame
    void Update()
    {

        delayTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftControl) && delayTimer > delayTime){
            delayTimer = 0;
            StartCoroutine("SpawnAmmo");
        }
    }


    private void SpawnAmmo()
    {
        GameObject newAmmo = Instantiate(ammo, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(newAmmo, destroyTime);
    }

    
}
