using UnityEngine;
using System.Collections;

class DealDamage : MonoBehaviour {

	public static void ApplyDamage(GameObject DealTo,float Amount){
		if (DealTo.GetComponent<Enemy> () != null)
			DealTo.GetComponent<Enemy> ().Health -= Amount;
	}
	public static void ReduceDamage(GameObject ReduceTo){
		ReduceTo.AddComponent<UnityEngine.UI.Text>().text = "Reduced";
	}

}
