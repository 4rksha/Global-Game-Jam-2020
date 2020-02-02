using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAI : MonoBehaviour
{
    NavMeshAgent agent;
    Vector3 currentDestination;
    public Transform target;
    Animator animator;

    private bool isAttacking = false;
    private bool isMoving = false;

    private float cooldown = 2f;

    void Start()
    {
        animator = transform.GetChild(0).GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        isAttacking = animator.GetBool("isAttacking");
        isMoving = animator.GetBool("isMoving");
        if (isMoving) 
        {
            MoveToDestination(); 
        }
        else if (isAttacking)
        {

        }
        else if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            initiateNextMove();
        }


    }

    void MoveToDestination()
    {
        agent.destination = currentDestination;
        if (Vector3.Distance(transform.position, currentDestination) <= 5.2)
        {
            animator.SetBool("isMoving", false);
            animator.SetBool("isAttacking", true);
        }
    }

    void initiateNextMove() {
            cooldown = 3f;
            currentDestination = target.position;
            transform.LookAt(new Vector3(currentDestination.x, transform.position.y, currentDestination.z));
            if (Vector3.Distance(transform.position, currentDestination) <= 5.2)
            {
                isAttacking = true;
                animator.SetBool("isAttacking", true);
            }
            else
            {
                isMoving = true;
                animator.SetBool("isMoving", true);
            }
    }
}
