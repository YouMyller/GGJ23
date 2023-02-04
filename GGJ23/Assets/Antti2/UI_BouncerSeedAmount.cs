using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BouncerSeedAmount : MonoBehaviour
{
    Text txt;
    public GameObject SeedHolder;

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = SeedHolder.GetComponent<SeedHolder>().bouncerSeeds.ToString();
    }
}
