using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape)) Application.Quit();
	}

	public void PlayGame() {
		SceneManager.LoadScene ("GamePlay", LoadSceneMode.Single);
	}
}