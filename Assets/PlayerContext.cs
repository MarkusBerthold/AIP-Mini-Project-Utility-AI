using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public class PlayerContext : IAIContext {
    public PlayerContext(GameObject gameObject) {
        this.self = gameObject;
        this.observations = new List<GameObject>();
    }

    public GameObject self {
        get;
        private set;
    }

    public List<GameObject> observations {
        get;
        private set;
    }
}