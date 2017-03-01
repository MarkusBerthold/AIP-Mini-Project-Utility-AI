using Apex.AI;
using UnityEngine;

public sealed class MoveToRestaurant : ActionBase {

	public Vector3 restaurantDest = new Vector3 (17, 4, 11);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(restaurantDest);


	}
}