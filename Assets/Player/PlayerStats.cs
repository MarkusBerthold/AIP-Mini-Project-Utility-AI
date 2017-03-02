using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float Energy;
    public float DefaultEnergy, DecrementValueEnergy;

    public float Thirst;
    public float DefaultThirst, DecrementValueThirst;

    public float Bladder;
    public float DefaultBladder, DecrementValueBladder;

    public float Tiredness;
    public float DefaultTiredness, DecrementValueTiredness;
    

    private PlayerAIMovement _playerAIMovement;

	public bool isInRestaurant,isInRefreshments, isInHotel, isInToilet,
	player2InRestaurant, player2InRefreshments, player2InHotel, player2InToilet;

    void Awake() {
        Energy = DefaultEnergy;
        Thirst = DefaultThirst;
        Bladder = DefaultBladder;
        Tiredness = DefaultTiredness;

        _playerAIMovement = this.GetComponent<PlayerAIMovement>();
    }

    void Update() {
        if (player2InHotel) {
            GameObject.Find("Hotel").GetComponent<Renderer>().material.color = Color.red;
        } else if (player2InToilet) {
            GameObject.Find("Toilet").GetComponent<Renderer>().material.color = Color.red;
        } else if (player2InRestaurant) {
            GameObject.Find("Restaurant").GetComponent<Renderer>().material.color = Color.red;
        } else if (player2InRefreshments) {
            GameObject.Find("Refreshments").GetComponent<Renderer>().material.color = Color.red;
        } else {
            GameObject.Find("Hotel").GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("Toilet").GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("Restaurant").GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("Refreshments").GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void Eat() {
        Energy = DefaultEnergy;
    }

    public void Sleep() {
        Tiredness = DefaultTiredness;
    }

    public void Drink() {
        Thirst = DefaultThirst;
    }

    public void Pee() {
        Bladder = DefaultBladder;
    }

    public void Idle() {
        Energy -= DecrementValueEnergy;
        Tiredness -= DecrementValueTiredness;
        Thirst -= DecrementValueThirst;
        Bladder -= DecrementValueBladder;

    }

    public void MoveTo(Vector3 destination) {
        _playerAIMovement.Move(destination);
    }

    void OnEnable() {
        _playerAIMovement.enabled = true;
    }

    public void StopMoving() {
        _playerAIMovement.Move(this.transform.position);
    }
}
