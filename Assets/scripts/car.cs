using UnityEngine;
using System.Collections;

public class car : MonoBehaviour 
{

	public float speed;
	public float verticalspeed;
	Vector3 position;

	void Start () 
	{
		Debug.Log ("hello");
		position = transform.position;
	}
		
	// Update is called once per frame
	void Update () 
	{
		position.y += Input.GetAxis ("Vertical") * verticalspeed * Time.deltaTime;
		position.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		position.x=Mathf.Clamp (position.x, -2.74f, 2.67f);
		position.y = Mathf.Clamp (position.y, -4.42f, 4.37f);
		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="enemycar")
			Destroy(gameObject);
	}
}
