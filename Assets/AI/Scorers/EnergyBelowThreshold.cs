﻿using System;
using Apex.AI;
using Apex.Serialization;

public sealed class EnergyBelowThreshold : ContextualScorerBase {


    [ApexSerialization(defaultValue = false)]
    public bool not = false;

    [ApexSerialization(defaultValue = 30f)]
	public float threshold = 30f;

    public override float Score(IAIContext context) {
        var c = (PlayerContext)context;


		if (c.self.GetComponent<PlayerStats> ().Energy < threshold && c.self.GetComponent<PlayerStats> ().isInRestaurant) {
			if (not) {
				return 0f;
			}

			return this.score - c.self.GetComponent<PlayerStats> ().Energy;
		}

        if (not) {
				return this.score - c.self.GetComponent<PlayerStats>().Energy;
        }

        return 0f;
    	
	}
}
