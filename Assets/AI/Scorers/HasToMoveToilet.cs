﻿using System;
using Apex.AI;
using Apex.Serialization;

public sealed class HasToMoveToilet : ContextualScorerBase {
	[ApexSerialization(defaultValue = false)]
	public bool not = false;

	[ApexSerialization(defaultValue = 30f)]
	public float threshold = 30f;

	public override float Score(IAIContext context) {
		var c = (PlayerContext)context;

		if (c.self.GetComponent<PlayerStats>().Bladder < threshold  && !c.self.GetComponent<PlayerStats>().player2InToilet) {
			if (not) {
				return 0f;
			}

			return this.score;
		}

		if (not) {
			return this.score;
		}

		return 0f;
	}
}
