using Apex.AI;
using UnityEngine;

public sealed class MoveToRefreshments : ActionBase {

	public Vector3 refreshmentsDest = new Vector3 (-25.8f, 0f, 25.5f);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(refreshmentsDest);


	}
}