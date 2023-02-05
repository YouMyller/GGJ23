using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedHolder : MonoBehaviour
{

    public int bouncerSeeds;
    public int StaticPlatformSeeds;


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
