﻿using UnityEngine;

public class GameScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape)) Application.Quit();
	}
}