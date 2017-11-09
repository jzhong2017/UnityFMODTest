using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class FModTest : MonoBehaviour {

	private FMOD.System system;

	// Use this for initializations
	void Start () {
		FMOD.RESULT res = FMOD.Factory.System_Create (out system);
	}

	// Update is called once per frame
	void Update () {

	}
}
