using UnityEngine;
using System.Collections;
using Leap;



public class MakeSnowflake : MonoBehaviour {

	//public Transform movableCube;
	Controller m_leapController;

	Transform palm;

	// Use this for initialization
	void Start () {
		m_leapController = new Controller();
		palm = transform.FindChild("palm");
	}

	void OnTurnHandUp() {
		transform.Find("Magic").transform.position = palm.position + Vector3.up;
		transform.Find("Magic").particleSystem.Play();
	}
	
	// Update is called once per frame
	void Update () {

		if (m_leapController.Frame().Hands.Count == 0) return;

		for (int i=0; i<m_leapController.Frame().Hands.Count; i++) {
			Vector3 hand_normal = m_leapController.Frame().Hands[i].PalmNormal.ToUnity();
			
			HandModel hand = GetComponent<HandModel>();
			
			Hand leapHand = hand.GetLeapHand();
			
			//Debug.Log (hand.GetPalmRotation());
			
			//movableCube.position = hand.GetPalmPosition();
			
			//movableCube.GetComponent<MeshRenderer>().enabled = (hand.GetPalmRotation() * Vector3.down).y > 0;
			
			Vector3 palm_normal = -palm.up;
			bool palm_is_facing_up = Vector3.Dot(palm_normal, Vector3.up) > 0.6f;
			bool palm_is_moving_up = palm.rigidbody.velocity.y > 5.0f;
			
			if (palm_is_facing_up && palm_is_moving_up) OnTurnHandUp();
		}

	}
}
