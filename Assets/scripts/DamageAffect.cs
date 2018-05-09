using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAffect : MonoBehaviour {

    public bool isTower;
    public int damageAmount = 20;

	// Use this for initialization
	void Start () {
        if (isTower)
        {
            GameObject radius = transform.Find("RealRadius").gameObject;
            DamageAffect da = radius.AddComponent<DamageAffect>();
            da.isTower = false;
            da.damageAmount = damageAmount;
        }
    }
	
    void OnTriggerStay(Collider other)
    {
        GameObject collided = other.gameObject;
        collided.GetComponent<HealthHandle>().deal_damage(damageAmount);
    }
}
