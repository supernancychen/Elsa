using UnityEngine;
using System.Collections;
using Leap;

public class MakeSnowflakes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		HandModel hand = GetComponent<HandModel>();

		Hand leapHand = hand.GetLeapHand();

	}
}
