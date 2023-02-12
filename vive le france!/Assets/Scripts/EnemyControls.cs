using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed = 5;
    public float attackingDistance = 1;
    public Vector3 direction;

    private Animator animatorEnemy;
    private Rigidbody rigidbodyEnemy;
    private Transform target;
    public bool isFollowingTarget;
    private bool isAttackingTarget;
    private float chasingPlayer = 0.01f;
    public float currentAttackingTime;
    public float maxAttackingTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        isFollowingTarget = true;
        currentAttackingTime = maxAttackingTime;
        animatorEnemy = GetComponentInChildren<Animator>();
        rigidbodyEnemy = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectsWithTag("Player").transform;
    }

    // Update is called once per frame
    void FollowTarget()
    {
        if (!isFollowingTarget)
        {
            return;
        }
    }
}
