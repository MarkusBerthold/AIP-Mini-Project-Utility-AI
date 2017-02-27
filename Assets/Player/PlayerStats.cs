using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float Energy, DefaultEnergy, DecrementValue;

    private PlayerAIMovement _playerAIMovement;

    void Awake() {
        Energy = DefaultEnergy;
        _playerAIMovement = this.GetComponent<PlayerAIMovement>();
    }

    public void Eat() {
        Energy = DefaultEnergy;
    }

    public void Idle() {
        Energy -= DecrementValue;
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
