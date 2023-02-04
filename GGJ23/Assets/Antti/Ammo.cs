using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    
    public float forceAmount;
    private Vector3 v3Force;

    private Rigidbody player;

    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
	player = GameObject.Find("PlayerController").GetComponent<Rigidbody>();
        v3Force = forceAmount * transform.up + player.velocity;
    }

    // Update is called once per frame
    void Update()
    {
         rb.AddForce(v3Force * Time.deltaTime, ForceMode.Force);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
            Destroy(other.gameObject);

        if (other.gameObject.tag != "Player" || other.gameObject.tag != "JumpTrigger" || other.gameObject.tag != "PlayerFeet")
        {
            print("I die");
            Destroy(this);
        }
    }
}
