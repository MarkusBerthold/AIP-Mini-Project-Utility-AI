using Apex.AI;
using UnityEngine;

public sealed class MoveToHotel : ActionBase {

	public Vector3 hotelDest = new Vector3 (29.22f, 0f, -27.45f);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(hotelDest);


	}
}