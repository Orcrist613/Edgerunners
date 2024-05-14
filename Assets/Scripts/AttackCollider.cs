using System;
using UnityEngine;
using System.Collections;

public class AttackCollider : MonoBehaviour
{
    public int Engel = 0, Dusman = 0;
    public AudioSource Cit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Destroy(collision.gameObject);
            Engel++;
            Cit.Play();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Dusman++;
        }
    }
}
