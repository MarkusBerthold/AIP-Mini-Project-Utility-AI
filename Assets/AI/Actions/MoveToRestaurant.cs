using Apex.AI;
using UnityEngine;

public sealed class MoveToRestaurant : ActionBase {

	public Vector3 restaurantDest = new Vector3 (16.7f, 0f, 11.37f);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(restaurantDest);


	}
}