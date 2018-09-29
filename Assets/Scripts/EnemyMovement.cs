using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float velocity;
	public float range;
	private float contador;



	void Start ()
	{
		contador = 0;
	}
	void Update ()
	{
		if(range>=contador)
		{
			transform.position += (transform.up * (velocity * Time.deltaTime));
			contador += Time.deltaTime;
			print(contador);
		}
		else
		{
			transform.rotation=Quaternion.Euler(new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z+180));
			contador = 0;

		}
	}
}
