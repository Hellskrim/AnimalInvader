using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Lizard : MonoBehaviour
{

    private Animator animator;
    private Attacker attacker;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject currentObj = collider.gameObject;
        if (!currentObj.GetComponent<Defender>())
        {
            return;
        }
        else
        {
            animator.SetBool("isAttacking", true);
            attacker.Attack(currentObj);
        }
    }
}

