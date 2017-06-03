using UnityEngine;
using UnityEngine.UI;

public class GameOverControl : MonoBehaviour
{
	public Text txScore;
	public Text txGameOver;
	public Text txLastScore;
	public Text labelScore;
	public Button btnRestart;
	bool enable = false;
	public Image btnControl;
	public Image btnFire;
	public Text txtFire;
	public Image panel;

	// Use this for initialization
	void Start()
	{
		SetVisible(false);
	}

	void SetVisible(bool visible)//visible
	{
		panel.enabled = visible;
		txGameOver.enabled = visible;
		txLastScore.enabled = visible;
		labelScore.enabled = visible;
		btnRestart.gameObject.SetActive(visible);
		txScore.enabled = !visible;
		btnControl.enabled = !visible;
		btnFire.enabled = !visible;
		txtFire.enabled = !visible;
		enable = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Data.isGameOver && !enable)
		{
			txLastScore.text = Data.Score.ToString();
			SetVisible(true);
			enable = true;
		}
	}

	public void Restart()
	{
		Data.isGameOver = false;
		Data.Score = 0;
		Application.LoadLevel(0);
	}
}