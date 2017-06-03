using UnityEngine;

public class MonsterMove : MonoBehaviour {

	GameObject player;
	bool isDestroy = false;
	Animator animator;

	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!Data.isGameOver)
		{
			transform.LookAt(player.transform);
			transform.Translate(Vector3.forward * Time.deltaTime * 1f);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag.Equals("Player"))
		{
			Data.isGameOver = true;
			Destroy(gameObject);
		}

		if (collision.gameObject.tag.Equals("Peluru"))
		{
			isDestroy = true;
			Data.Score++;
			animator.SetBool("isDead", true);
			Destroy (gameObject);
		}
	}
}