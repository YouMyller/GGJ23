using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IseeU : MonoBehaviour
{

    public float chaseEnemyDelay;

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
            StartCoroutine("ChaseEnemy");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("ReturnEnemy");
        }
    }

    public IEnumerator ChaseEnemy()
    {
        yield return new WaitForSeconds(chaseEnemyDelay);
        transform.parent.GetComponent<Enemy>().StartChase();


    }

    public IEnumerator ReturnEnemy()
    {
        yield return new WaitForSeconds(chaseEnemyDelay);
        transform.parent.GetComponent<Enemy>().GoHome();


    }
}

