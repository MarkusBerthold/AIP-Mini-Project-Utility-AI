using Apex.AI;
using UnityEngine;

public sealed class MoveToRefreshments : ActionBase {

	public Vector3 refreshmentsDest = new Vector3 (-26, 1, 25);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(refreshmentsDest);


	}
}