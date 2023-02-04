using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedHolder : MonoBehaviour
{

    public int bouncerSeeds;
    public int StaticPlatformSeeds;

    // Start is called before the first frame update
    void Start()
    {
        bouncerSeeds = 2;
        StaticPlatformSeeds = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveBouncerSeed()
    {
        bouncerSeeds--;
    }

    public void RemoveStaticPlatformSeed()
    {
        StaticPlatformSeeds--;
    }

    public void AddBouncerSeed()
    {
        bouncerSeeds++;
    }

    public void AddStaticPlatformSeed()
    {
        StaticPlatformSeeds++;
    }
}
