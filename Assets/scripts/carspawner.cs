using UnityEngine;
using System.Collections;

public class carspawner : MonoBehaviour
{
	public GameObject car;
	public float delaytimer;
	float timer;

	void Start () 
	{
		timer = delaytimer;
	}
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			Vector3 carPos = new Vector3 (Random.Range (-2.27f, 2.4f), transform.position.y, transform.position.z);
			Instantiate (car, carPos, transform.rotation);
			timer = delaytimer;
		}
	}
}
