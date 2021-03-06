﻿using System;
using Apex.AI;
using Apex.Serialization;

public sealed class ThirstBelowThreshold : ContextualScorerBase {


    [ApexSerialization(defaultValue = false)]
    public bool not = false;

    [ApexSerialization(defaultValue = 30f)]
    public float threshold = 30f;

    public override float Score(IAIContext context) {
        var c = (PlayerContext)context;


		if (c.self.GetComponent<PlayerStats>().Thirst < threshold && c.self.GetComponent<PlayerStats>().isInRefreshments) {
            if (not) {
                return 0f;
            }

			return this.score - c.self.GetComponent<PlayerStats> ().Thirst;
        }

        if (not) {
			return this.score - c.self.GetComponent<PlayerStats> ().Thirst;
        }

        return 0f;
    }
}
