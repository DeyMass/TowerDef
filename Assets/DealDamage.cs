using UnityEngine;
using System.Collections;

class DealDamage : MonoBehaviour {

	public static void ApplyDamage(GameObject DealTo, float Amount, TypeOfDamage TypeOfTower){
		DamageType TypeOfEnemy = DealTo.GetComponent<DamageType>().SelfType;

		if (TypeOfEnemy == TypeOfTower)
			Debug.Log ("Types are equals, and no damage Received");
		if (TypeOfEnemy )
		if (DealTo.GetComponent<Enemy> () != null)
			DealTo.GetComponent<Enemy> ().Health -= Amount;
	}

}
