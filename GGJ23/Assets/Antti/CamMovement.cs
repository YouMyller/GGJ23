using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    private GameObject Player;
    private Vector3 pos;
    public float offsetY;
    public float offsetZ;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new Vector3(Player.transform.position.x, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        transform.position = pos;
    }
}
