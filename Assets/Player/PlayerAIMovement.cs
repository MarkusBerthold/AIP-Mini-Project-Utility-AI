using UnityEngine;
using Apex;

public class PlayerAIMovement : MonoBehaviour {

    public float turnSpeed = 10f;

    private UnityEngine.AI.NavMeshAgent _navMeshAgent;
    private Transform _lookAtTransform;

    void Awake() {
        _navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void FixedUpdate() {
        Turn();
    }

    void OnEnable() {
        _navMeshAgent.enabled = true;
    }

    void OnDisable() {
        _navMeshAgent.enabled = false;
    }

    public void Move(Vector3 destination) {
        _navMeshAgent.SetDestination(destination);
    }

    /// <summary>
    /// Set the position to look at. Set to null is the Ai should stop looking
    /// </summary>
    /// <param name="lookAtTransform"></param>
    public void LookAt(Transform lookAtTransform) {
        _lookAtTransform = lookAtTransform;

        if (lookAtTransform == null) {
            _navMeshAgent.updateRotation = true;
        } else {
            _navMeshAgent.updateRotation = false;
        }
    }

    private void Turn() {
        if (_lookAtTransform != null) {
            Vector3 lookRotation = (_lookAtTransform.position - transform.position).OnlyXZ();

            // Create a quaternion (rotation) based on looking down the vector from the player to the target.
            Quaternion newRotatation = Quaternion.LookRotation(lookRotation);

            transform.rotation = Quaternion.Slerp(transform.rotation, newRotatation, Time.fixedDeltaTime * turnSpeed);
        }
    }
}
