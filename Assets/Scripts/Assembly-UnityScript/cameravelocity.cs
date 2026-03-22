using System;
using UnityEngine;

[Serializable]
public class cameravelocity : MonoBehaviour
{
	private float speed;

	public cameravelocity()
	{
		speed = 12f;
	}

	public virtual void Update()
	{
		float x = speed;
		Vector3 velocity = GetComponent<Rigidbody>().velocity;
		float num = (velocity.x = x);
		Vector3 vector = (GetComponent<Rigidbody>().velocity = velocity);
	}

	public virtual void receiveSpeed(float theSpeed)
	{
		speed = theSpeed;
	}

	public virtual void Main()
	{
	}
}
