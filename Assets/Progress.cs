using UnityEngine;
using System.Collections;

public class Progress : MonoBehaviour {
    public float Tiredness;
    public float Bladder;
    public float Energy;
    public float Thirst;

    void OnGUI() {
        //draw the background:
        GUI.BeginGroup(new Rect(20, 20, 100, 50));
        GUI.Box(new Rect(0, 50, 20, -Energy),"");
        GUI.Box(new Rect(25, 50, 20, -Thirst), "");
        GUI.Box(new Rect(50, 50, 20, -Bladder), "");
        GUI.Box(new Rect(75, 50, 20, -Tiredness), "");
        GUI.EndGroup();
    }

    void Update() {
        Tiredness = GameObject.Find("Player1").GetComponent<PlayerStats>().Tiredness;
        Bladder = GameObject.Find("Player1").GetComponent<PlayerStats>().Bladder;
        Energy = GameObject.Find("Player1").GetComponent<PlayerStats>().Energy;
        Thirst = GameObject.Find("Player1").GetComponent<PlayerStats>().Thirst;
    }
}