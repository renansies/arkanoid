using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
	public float Speed = 150;

	private void FixedUpdate ()
	{
		float h = Input.GetAxisRaw("Horizontal");
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * Speed;
	}
}
