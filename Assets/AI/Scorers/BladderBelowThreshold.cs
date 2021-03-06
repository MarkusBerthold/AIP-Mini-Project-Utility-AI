﻿using System;
using Apex.AI;
using Apex.Serialization;

public sealed class BladderBelowThreshold : ContextualScorerBase {


    [ApexSerialization(defaultValue = false)]
    public bool not = false;

    [ApexSerialization(defaultValue = 30f)]
    public float threshold = 30f;

    public override float Score(IAIContext context) {
        var c = (PlayerContext)context;


		if (c.self.GetComponent<PlayerStats>().Bladder < threshold && c.self.GetComponent<PlayerStats>().isInToilet) {
            if (not) {
                return 0f;
            }

			return this.score-c.self.GetComponent<PlayerStats>().Bladder;
        }

        if (not) {
			return this.score-c.self.GetComponent<PlayerStats>().Bladder;
        }

        return 0f;
    }
}
