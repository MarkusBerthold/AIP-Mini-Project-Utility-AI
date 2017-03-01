using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantDistance: MonoBehaviour {

	public GameObject player;

	private Vector3 playerpos;
	private Vector3 restaurantpos;

	public void Start(){
		restaurantpos = transform.position;
	}

	public void Update(){
		playerpos = player.transform.position;

		if (Vector3.Distance (playerpos, restaurantpos) < 10) {
			player.GetComponent<PlayerStats> ().isInRestaurant = true;
		} else if (Vector3.Distance (playerpos, restaurantpos) > 10) {
			player.GetComponent<PlayerStats> ().isInRestaurant = false;
		}
	}
}
