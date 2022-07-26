using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AiTestScript : MonoBehaviour
{

    public float wanderRadius;
    public float wanderTimer;
    //Defines variables: the radius of the sphere that they randomly pick, second variable is the time inbetween point A to point B.

    private Transform target;
    //Where the AI tries to go to.
    private UnityEngine.AI.NavMeshAgent agent;
    //The individual entity
    private float timer;
    //time inbetween actions.

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //Get the component.
        timer = wanderTimer;
        //set the timer to the public timer on boot.
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //increase time every frame.

        if (timer >= wanderTimer)
        //if timer is greater or equal to wandertimer.
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            //set the new position based on a random sphere within wander radius length.
            agent.SetDestination(newPos);
            //set the new destination to the pos
            timer = 0;
            //reset timer
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    //Define the random navSphere
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        //random direction picked.

        randDirection += origin;
        //random direction is increased by origin. adds an offset.

        UnityEngine.AI.NavMeshHit navHit;
        //get navhit.

        UnityEngine.AI.NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        //put position used for debugging

        return navHit.position;
        //return the navhit position to use in where the AI goes.
    }
}