using Apex.AI;

public sealed class Sleep : ActionBase {
    public override void Execute(IAIContext context) {
        // Cast the provided context to your concrete context type
        var c = (PlayerContext)context;

        var player = c.self;

        player.GetComponent<PlayerStats>().Sleep();

        // Put logic here
    }
}