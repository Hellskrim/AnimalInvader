using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour {

    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void setSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void strikeCurrentTarget(float damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.dealDamage(damage);
            }
        }
    }

    public void Attack(GameObject currentObj)
    {
        currentTarget = currentObj;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
    }
}
