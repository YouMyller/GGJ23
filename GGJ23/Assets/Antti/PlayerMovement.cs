using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public float speed;
    private Rigidbody rb;
    private Vector3 forward;
    private Vector3 right;
    private float timer;
    private float canTurn;
    private bool grounded;
    public float airMovementSlowRatio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forward = transform.forward * speed;
        right = transform.right * speed;
        canTurn = 0.125f;
        timer = canTurn;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if(grounded == true)
        {
            

            if (Input.GetKey(KeyCode.W))
            {

                rb.AddForce(forward);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.S))
            {

                rb.AddForce(-forward);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.D))
            {

                rb.AddForce(right);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-right);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, -90, 0);
                }
            }


            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                rb.AddForce(forward + right / 2);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                rb.AddForce(forward + -right / 2);
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                rb.AddForce(-forward + right / 2);
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                rb.AddForce(-forward + -right / 2);
            }

            if(Input.GetKey(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKeyUp(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                timer = 0;
            }


            if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKeyUp(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                timer = 0;
            }

        }

        if(grounded == false)
        {
            

            if (Input.GetKey(KeyCode.W))
            {

                rb.AddForce(forward * airMovementSlowRatio);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.S))
            {

                rb.AddForce(-forward * airMovementSlowRatio);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.D))
            {

                rb.AddForce(right * airMovementSlowRatio);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }

            

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-right * airMovementSlowRatio);

                if (timer > canTurn)
                {
                    transform.eulerAngles = new Vector3(0, -90, 0);
                }
            }


            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                rb.AddForce(forward + right / 2 * airMovementSlowRatio);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                rb.AddForce(forward + -right / 2 * airMovementSlowRatio);
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                rb.AddForce(-forward + right / 2 * airMovementSlowRatio);
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                rb.AddForce(-forward + -right / 2 * airMovementSlowRatio);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKeyUp(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                timer = 0;
            }


            if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKeyUp(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                timer = 0;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, -135, 0);
                timer = 0;
            }
        }

        


        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            timer = 0;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            timer = 0;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            timer = 0;
        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            grounded = true;
            
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            grounded = false;
        }
    }
}
