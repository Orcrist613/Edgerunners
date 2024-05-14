using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Animator animator;
    public AudioSource Savurma;
    public GameObject AttackCollider;
    //public AudioSource EnemyDeath;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if (animator.GetBool("Death"))
        {
            AttackCollider.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AttackAnim"))
        {
            animator.SetBool("EnemyAttack", true);
            Savurma.Play();
            Invoke("AttackEnd", 1.2f);
            Destroy(gameObject, 2);
        }
        if (collision.gameObject.CompareTag("Attack"))
        {
            //EnemyDeath.Play();
            animator.SetBool("Death", true);
            Destroy(gameObject, 1.5f);
        }
    }

    void AttackEnd()
    {
        animator.SetBool("EnemyAttack", false);
        AttackCollider.SetActive(false);
    }
}
