using UnityEngine;
using System.Collections;

public class AttachTosSphere : MonoBehaviour {

	public bool isDragged;

	void OnTriggerStay2D(Collider2D col){
		//print ("+");
		if (!isDragged) {
			GameObject Attack = GameObject.Find (col.name);
            DealDamage.ApplyDamage(Attack, 1F, gameObject.GetComponent<DamageType>().SelfType);
			//DealDamage.ReduceDamage (Attack);
		}
	}

}
