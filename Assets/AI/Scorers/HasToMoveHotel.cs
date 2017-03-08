using System;
using Apex.AI;
using Apex.Serialization;

public sealed class HasToMoveHotel : ContextualScorerBase {
	[ApexSerialization(defaultValue = false)]
	public bool not = false;

	[ApexSerialization(defaultValue = 30f)]
	public float threshold = 30f;

	public override float Score(IAIContext context) {
		var c = (PlayerContext)context;

		if (c.self.GetComponent<PlayerStats>().Tiredness < threshold && !c.self.GetComponent<PlayerStats>().player2InHotel) {
			if (not) {
				return 0f;
			}

			return this.score - c.self.GetComponent<PlayerStats> ().Tiredness;
		}

		if (not) {
			return this.score - c.self.GetComponent<PlayerStats> ().Tiredness;
		}

		return 0f;
	}
}
