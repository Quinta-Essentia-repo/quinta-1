using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This resorts combat for all characters. */

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{

    public float attackRate = 1f;
    private float attackCountdown = 0f;
    public PlayerHandler handler;
    public event System.Action OnAttack;

    public Slider healthBarPos;

    CharacterStats myStats;
    CharacterStats enemyStats;


    void Start()
    {
        myStats = GetComponent<CharacterStats>();
        healthBarPos = handler.healthBar;
    }

    void Update()
    {
        attackCountdown -= Time.deltaTime;
    }

    public void Attack(CharacterStats enemyStats)
    {
        if (attackCountdown <= 0f)
        {
            this.enemyStats = enemyStats;
            attackCountdown = 1f / attackRate;

            StartCoroutine(DoDamage(enemyStats, .6f));

            if (OnAttack != null)
            {
                OnAttack();
            }
        }
    }


    IEnumerator DoDamage(CharacterStats stats, float delay)
    {
        print("Start");
        yield return new WaitForSeconds(delay);

        Debug.Log(transform.name + " swings for " + myStats.damage + " damage");
        enemyStats.TakeDamage(myStats.damage);




    }


}
