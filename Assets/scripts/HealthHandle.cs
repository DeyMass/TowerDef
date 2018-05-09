using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthHandle : MonoBehaviour {

    public int MaxHealth = 500;
    private int health;

    void Start()
    {
        health = MaxHealth;
    }

    int get_tickHealth()
    {
        return health;
    }
    int get_maxHealth()
    {
        return MaxHealth;
    }
    public void deal_damage(int amount)
    {
        health -= amount;
        GetComponentInChildren<healthBar>().UpdateHealthBar(health, MaxHealth);
        if (health <= 0) Destroy(this.gameObject);
    }
    void Update() {
    }
}
