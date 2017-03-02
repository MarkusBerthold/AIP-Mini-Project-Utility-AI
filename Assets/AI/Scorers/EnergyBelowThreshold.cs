using System;
using Apex.AI;
using Apex.Serialization;

public sealed class EnergyBelowThreshold : ContextualScorerBase {


    [ApexSerialization(defaultValue = false)]
    public bool not = false;

    [ApexSerialization(defaultValue = 30f)]
	public float threshold = 30f;

    public override float Score(IAIContext context) {
        var c = (PlayerContext)context;


		if (c.self.GetComponent<PlayerStats>().Energy < threshold && c.self.GetComponent<PlayerStats>().isInRestaurant) {
            if (not) {
                return 0f;
            }

			return this.score/(1-(c.self.GetComponent<PlayerStats>().Energy/100));
        }

        if (not) {
			return this.score/(1-(c.self.GetComponent<PlayerStats>().Energy/100));
        }

        return 0f;
    }
}
