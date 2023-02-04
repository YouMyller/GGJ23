using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawn : MonoBehaviour
{
    private bool CanPutSeed;
    public GameObject Bouncer;
    public GameObject StaticPlatform;
    public GameObject SeedHolder;
    
    private bool IsActive;

    // Start is called before the first frame update
    void Start()
    {
        
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(CanPutSeed == true && Input.GetKeyDown(KeyCode.Q) && SeedHolder.GetComponent<SeedHolder>().bouncerSeeds > 0 && IsActive == true)
        {
            SeedHolder.GetComponent<SeedHolder>().RemoveBouncerSeed();
            GameObject newAmmo = Instantiate(Bouncer, gameObject.transform.position, gameObject.transform.rotation);
            IsActive = false;
            
        }

        if (CanPutSeed == true && Input.GetKeyDown(KeyCode.E ) && SeedHolder.GetComponent<SeedHolder>().StaticPlatformSeeds > 0 && IsActive == true)
        {
            SeedHolder.GetComponent<SeedHolder>().RemoveStaticPlatformSeed();
            GameObject newAmmo = Instantiate(StaticPlatform, gameObject.transform.position, gameObject.transform.rotation);
            IsActive = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            CanPutSeed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CanPutSeed = false;
        }
    }
}
