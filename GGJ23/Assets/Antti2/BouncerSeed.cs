using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerSeed : MonoBehaviour
{

    public GameObject SeedHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SeedHolder.GetComponent<SeedHolder>().AddBouncerSeed();
            Destroy(this.gameObject);
        }
    }
}
