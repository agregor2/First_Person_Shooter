using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public Transform player;  // Reference to the player's position
    public float detectionRange = 10f;  // Distance at which the enemy will detect the player
    private NavMeshAgent agent;  // Reference to the NavMeshAgent component

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Get the NavMeshAgent attached to the enemy
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        // If the player is within the detection range, the enemy will chase
        if (distance < detectionRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasing();
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);  // Set the player's position as the destination
    }

    void StopChasing()
    {
        agent.SetDestination(transform.position);  // Stop moving if the player is out of range
    }
}
