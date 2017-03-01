using Apex.AI;
using UnityEngine;

public sealed class MoveToIdle : ActionBase {

	public Vector3 idleDest = new Vector3 (0, 0, 0);

	public override void Execute(IAIContext context) {
		// Cast the provided context to your concrete context type
		var c = (PlayerContext)context;

		var player = c.self;

		player.GetComponent<PlayerStats>().MoveTo(idleDest);


	}
}