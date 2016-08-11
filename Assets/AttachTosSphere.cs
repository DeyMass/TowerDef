using UnityEngine;
using System.Collections;

public class AttachTosSphere : MonoBehaviour {

	void OnTriggerStay2D(Collider2D col){
		//print ("+");
		GameObject Attack = GameObject.Find (col.name);
		DealDamage.ApplyDamage(Attack, 1F);
		//DealDamage.ReduceDamage (Attack);
	}

}
