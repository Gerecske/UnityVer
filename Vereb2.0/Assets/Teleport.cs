using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Transform a;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		collision.transform.position = a.position;
	}
}
