using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="enemycar")
			Destroy(col.gameObject);

			}

}
