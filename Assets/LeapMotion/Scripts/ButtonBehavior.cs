using UnityEngine;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {
	Vector3 myPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myPosition = transform.position;
		if(myPosition.x < -2) 
			transform.position = new Vector3(-2, myPosition.y, myPosition.z);
	}
	
	void OnCollisionEnter(Collision info) {
		renderer.material.color = new Color(0.5f,1,1);
	}

	void OnCollisionExit(Collision info) {
		renderer.material.color = new Color(1,1,1);
	}
}
