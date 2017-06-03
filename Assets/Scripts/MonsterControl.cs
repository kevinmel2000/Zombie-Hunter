using UnityEngine;

public class MonsterControl: MonoBehaviour {

	[SerializeField]
	private GameObject monster;
	[SerializeField]
	private GameObject player;

	GameObject[] monsters;
	float timer = 0;

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if(!Data.isGameOver)
		if (timer > 5f && GameObject.FindGameObjectsWithTag("Monster").Length < 5)
		{
			Vector3 posRecomended;
			do
			{
				posRecomended = new Vector3(Random.Range(80, 100), 0, Random.Range(80, 100));
			} while ( Vector3.Distance(posRecomended , player.transform.position) < 5f);
			Instantiate(monster, posRecomended, Quaternion.identity);
			timer = 0;
		}
	}
}