using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRestricted : MonoBehaviour {
	public GameObject ITarget;
	public Transform ITargetT;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ITargetT= ITarget.GetComponent<Transform>();
		transform.position = new Vector3(ITargetT.position.x*2,0.201f,ITargetT.position.z*2);
	}
}
