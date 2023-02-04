using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;
    private Vector3 JumpForce;
    public float jumpStrength;
    public float JumpHeld;
    public float JumpHeldTimer;
    private bool grounded;
    public float coyoteWaitTime;
    private int jumpCount;
    public float fallBoost;
    private bool earlyJump;
    private bool ready2JUmp;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        JumpForce = new Vector3(0, jumpStrength,0);
        jumpCount = 0;
        earlyJump = false;
    }

    // Update is called once per frame
    void Update()
    {

        JumpHeldTimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true && jumpCount == 0)
        {
            rb.AddForce(JumpForce, ForceMode.Force);
            JumpHeldTimer = 0;
            jumpCount = 1;
        }

        if (Input.GetKey(KeyCode.Space ) && JumpHeldTimer < 0.5f)
        {
            rb.AddForce(0, JumpHeld, 0, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded == false && earlyJump == true)
        {
            ready2JUmp = true;
        }

        if (grounded == false && rb.velocity.y < 0)
        {
            rb.AddForce(0, fallBoost, 0, ForceMode.Force);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Platform")
        {
            grounded = true;
            jumpCount = 0;
        }

        if(collision.collider.tag == "Platform" && ready2JUmp == true)
        {
            earlyJump = false;
            ready2JUmp = false;
            rb.AddForce(JumpForce, ForceMode.Force);
            JumpHeldTimer = 0;
            jumpCount = 1;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            StartCoroutine("CoyoteJump");
        }
    }

    private IEnumerator CoyoteJump()
    {
        yield return new WaitForSeconds(coyoteWaitTime);
        grounded = false;
        
    }

    public void grounderMethod() {

        earlyJump = true;

    }
}
