using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public GameObject deathEffect;
    public bool isInvulnerable = false;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");
        if (currentHealth <= 0) {
            Die();
        }
    }
    // Update is called once per frame

    void Die() {
        Debug.Log("Enemy died!");
        animator.SetBool("isDead",true);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
