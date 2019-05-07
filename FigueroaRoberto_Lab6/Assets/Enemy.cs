using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject[] positions;
    private int index = 0;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<NavMeshAgent>().remainingDistance < 0.8f)
        {
            GetComponent<NavMeshAgent>().SetDestination(NewPoint());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("player")) { Destroy(collision.gameObject); }
    }

    private Vector3 NewPoint()
    {
        if(index == 2)
        {
            index = 0;
        }
        index += 1;

        
        return positions[index].transform.position;
    }
}
