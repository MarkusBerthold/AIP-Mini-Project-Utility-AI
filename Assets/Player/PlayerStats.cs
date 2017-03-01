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
    
    public float moveStat;

    private PlayerAIMovement _playerAIMovement;

	public bool isInRestaurant,isInRefreshments, isInHotel, isInToilet;

    void Awake() {
        Energy = DefaultEnergy;
        Thirst = DefaultThirst;
        Bladder = DefaultBladder;
        Tiredness = DefaultTiredness;

        _playerAIMovement = this.GetComponent<PlayerAIMovement>();
		moveStat = 100;
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
