using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	private PlayerAIMovement _playerAIMovement;

	public Vector3[] positions;


	// Use this for initialization
	void Start () {

		_playerAIMovement = this.GetComponent<PlayerAIMovement>();

		StartCoroutine (MoveToRandom());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveTo(Vector3 destination) {
		_playerAIMovement.Move(destination);
	}

	public void StopMoving() {
		_playerAIMovement.Move(this.transform.position);
	}

	IEnumerator MoveToRandom(){
		while(true){

		MoveTo (positions[Random.Range(0,4)]);

		yield return new WaitForSeconds(Random.Range(3,8)); // waits random seconds betweel 6 and 15
		}
	}
}
