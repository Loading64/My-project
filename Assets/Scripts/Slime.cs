using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Slime : MonoBehaviour
{
    public int health;
    public Transform player;
    public Vector3 destination;
    public NavMeshAgent agent;
    public int damage;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    void Update()
    {
        //UnityEngine.Debug.Log(agent.destination);
        // Update destination if the target moves one unit
        if (Vector3.Distance(destination, player.position) > 1.0f)
        {
            destination = player.position;
            agent.destination = destination;
        }

    }
    public void damagetaken(int damage)
    {
        health -= damage;
        if (health <= 0.1)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        }
    }

}
