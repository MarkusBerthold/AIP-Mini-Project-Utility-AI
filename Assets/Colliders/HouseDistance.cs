using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDistance: MonoBehaviour {

	public GameObject player;

	private Vector3 playerpos;
	private Vector3 housepos;

	public void Start(){
		housepos = transform.position;
	}

	public void Update(){
		playerpos = player.transform.position;

		if (Vector3.Distance (playerpos, housepos) < 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().isInRestaurant = true;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().isInRestaurant = true;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().isInRestaurant = true;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().isInRestaurant = true;
		} else if (Vector3.Distance (playerpos, housepos) > 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().isInRestaurant = false;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().isInRestaurant = false;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().isInRestaurant = false;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().isInRestaurant = false;
		}
	}
}
