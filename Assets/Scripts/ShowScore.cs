using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	public Text txScore;

	// Update is called once per frame
	void FixedUpdate () {
		txScore.text = Data.Score.ToString();
	}
}