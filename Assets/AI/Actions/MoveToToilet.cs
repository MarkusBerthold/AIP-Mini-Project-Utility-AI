using Apex.AI;
using UnityEngine;

public sealed class MoveToToilet : ActionBase {

	public Vector3 toiletDest = new Vector3 (-10, 0f, -10);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(toiletDest);


	}
}