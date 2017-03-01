using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDistance: MonoBehaviour {

	public GameObject player;
	public GameObject player2;


	private Vector3 playerpos;
	private Vector3 player2pos;
	private Vector3 housepos;

	public void Start(){
		housepos = transform.position;
	}

	public void Update(){
		playerpos = player.transform.position;
		player2pos = player2.transform.position;


		if (Vector3.Distance (playerpos, housepos) < 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().isInRestaurant = true;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().isInToilet = true;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().isInHotel = true;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().isInRefreshments = true;
		} else if (Vector3.Distance (playerpos, housepos) > 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().isInRestaurant = false;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().isInToilet = false;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().isInHotel = false;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().isInRefreshments = false;
		}


		if (Vector3.Distance (player2pos, housepos) < 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().player2InRestaurant = true;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().player2InToilet = true;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().player2InHotel = true;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().player2InRefreshments = true;
		} else if (Vector3.Distance (player2pos, housepos) > 10) {
			if(this.name == "Restaurant")
				player.GetComponent<PlayerStats> ().player2InRestaurant = false;
			else if (this.name == "Toilet")
				player.GetComponent<PlayerStats> ().player2InToilet = false;
			else if (this.name == "Hotel")
				player.GetComponent<PlayerStats> ().player2InHotel = false;
			else if (this.name == "Refreshments")
				player.GetComponent<PlayerStats> ().player2InRefreshments = false;
		}



	}
}
