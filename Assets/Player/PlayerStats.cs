using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float Energy, DefaultEnergy, DecrementValue;

    void Awake() {
        Energy = DefaultEnergy;
    }

    public void Eat() {
        Energy = DefaultEnergy;
    }

    public void Idle() {
        Energy -= DecrementValue;
    }

}
