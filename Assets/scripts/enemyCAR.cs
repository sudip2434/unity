using UnityEngine;
using System.Collections;

public class enemyCAR : MonoBehaviour 
{
	public float speed;

	void Start () 
	{
		Debug.Log ("start");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(new Vector3(1,0,0)*speed*Time.deltaTime);
	}
}
