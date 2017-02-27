using Apex.AI;

public sealed class Idle : ActionBase {
    public override void Execute(IAIContext context) {
        // Cast the provided context to your concrete context type
        var c = (PlayerContext)context;

        var player = c.self;

        player.GetComponent<PlayerStats>().Idle();

        // Put logic here
    }
}