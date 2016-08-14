using UnityEngine;
using System.Collections;

public enum TypeOfDamage {Fire, Water, Wind, Earth, Electricity, Uknown};
public enum Place {Air, Land, AirLand};

public struct Info{
	public TypeOfDamage TypeOfRecievingDamage;
	public TypeOfDamage TypeOfDealingDamage;
	public Place PlaceOfEnemy;
	public Place StyleOfDamage;
}


public class DamageType : MonoBehaviour {

	public TypeOfDamage SelfType = TypeOfDamage.Uknown;

	void Start () {
		//Make tag equals to type of damage of the current 
		if (SelfType == TypeOfDamage.Uknown)
			switch (gameObject.tag) {
			case "Fire":
				SelfType = TypeOfDamage.Fire;
				break;
			case "Water":
				SelfType = TypeOfDamage.Water;
				break;
			case "Earth":
				SelfType = TypeOfDamage.Earth;
				break;
			case "Wind":
				SelfType = TypeOfDamage.Wind;
				break;
			case "Electricity":
				SelfType = TypeOfDamage.Electricity;
				break;
			default:
				throw new UnityException ("Untagged Tower/Enemy, or script is not attached to Tower/Enemy, or standart damage type is not set");
				break;
			}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
