using Apex.AI;
using UnityEngine;

public sealed class MoveToHotel : ActionBase {

	public Vector3 hotelDest = new Vector3 (40, 5, -18);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(hotelDest);


	}
}