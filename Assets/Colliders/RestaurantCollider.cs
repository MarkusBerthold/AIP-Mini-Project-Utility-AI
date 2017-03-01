using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantCollider : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider c){
		if(c.name == "Player1"){
			c.GetComponent<PlayerStats> ().isInRestaurant = true;
			print ("entered");
		}
		
	}

	void OnTriggerExit(Collider c){
		if(c.name == "Player1"){
			c.GetComponent<PlayerStats> ().isInRestaurant = false;
			print ("exit");
		}
	}
}
