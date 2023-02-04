using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    
    public Transform Player;
    public Vector3 og;
    private bool chasing;
    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        og = transform.position;
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(chasing == true && transform.position != Player.transform.position)
        {
            agent.SetDestination(Player.position);
        }

        if(chasing == false && transform.position != og)
        {
            agent.SetDestination(og);
        }

        if (!agent.isOnNavMesh)
        {
            
            agent.transform.position = og;
            agent.enabled = false;
            agent.enabled = true;
        }
    }

    public void StartChase()
    {
        chasing = true;
    }

    public void GoHome()
    {
        chasing = false;
    }
}
