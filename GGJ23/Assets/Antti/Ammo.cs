using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    
    public float forceAmount;
    private Vector3 v3Force;

    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        v3Force = forceAmount * transform.up;
    }

    // Update is called once per frame
    void Update()
    {
         rb.AddForce(v3Force * Time.deltaTime, ForceMode.Force);
    }
}
