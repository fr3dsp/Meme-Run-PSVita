using System;
using UnityEngine;

[Serializable]
public class cloudparallax : MonoBehaviour
{
	public float speed;

	public int frameSpeed;

	public Texture run1;

	public Texture run2;

	public Texture run3;

	public Texture run4;

	public Texture run5;

	public Texture run6;

	public Texture run7;

	public Texture run8;

	public Texture run9;

	public Texture run10;

	private GameObject cam;

	private float counter;

	public cloudparallax()
	{
		speed = 8f;
		frameSpeed = 10;
	}

	public virtual void Start()
	{
		cam = GameObject.Find("Main Camera");
		speed += UnityEngine.Random.Range(-1, 1);
	}

	public virtual void Update()
	{
		counter += Time.deltaTime * (float)frameSpeed;
		float x = speed;
		Vector3 velocity = GetComponent<Rigidbody>().velocity;
		float num = (velocity.x = x);
		Vector3 vector = (GetComponent<Rigidbody>().velocity = velocity);
		if (!(transform.position.x >= cam.transform.position.x - 22f))
		{
			float x2 = transform.position.x + 44f;
			Vector3 position = transform.position;
			float num2 = (position.x = x2);
			Vector3 vector3 = (transform.position = position);
		}
		if (!(counter <= 0f) && !(counter >= 1f) && GetComponent<Renderer>().material.mainTexture != run1)
		{
			GetComponent<Renderer>().material.mainTexture = run1;
		}
		if (!(counter <= 1f) && !(counter >= 2f) && GetComponent<Renderer>().material.mainTexture != run2)
		{
			GetComponent<Renderer>().material.mainTexture = run2;
		}
		if (!(counter <= 2f) && !(counter >= 3f) && GetComponent<Renderer>().material.mainTexture != run3)
		{
			GetComponent<Renderer>().material.mainTexture = run3;
		}
		if (!(counter <= 3f) && !(counter >= 4f) && GetComponent<Renderer>().material.mainTexture != run4)
		{
			GetComponent<Renderer>().material.mainTexture = run4;
		}
		if (!(counter <= 4f) && !(counter >= 5f) && GetComponent<Renderer>().material.mainTexture != run5)
		{
			GetComponent<Renderer>().material.mainTexture = run5;
		}
		if (!(counter <= 5f) && !(counter >= 6f) && GetComponent<Renderer>().material.mainTexture != run6)
		{
			GetComponent<Renderer>().material.mainTexture = run6;
		}
		if (!(counter <= 6f) && !(counter >= 7f) && GetComponent<Renderer>().material.mainTexture != run7)
		{
			GetComponent<Renderer>().material.mainTexture = run7;
		}
		if (!(counter <= 7f) && !(counter >= 8f) && GetComponent<Renderer>().material.mainTexture != run8)
		{
			GetComponent<Renderer>().material.mainTexture = run8;
		}
		if (!(counter <= 8f) && !(counter >= 9f) && GetComponent<Renderer>().material.mainTexture != run9)
		{
			GetComponent<Renderer>().material.mainTexture = run9;
		}
		if (!(counter <= 9f) && !(counter >= 10f) && GetComponent<Renderer>().material.mainTexture != run10)
		{
			GetComponent<Renderer>().material.mainTexture = run10;
		}
		if (!(counter <= 10f))
		{
			counter = 0f;
		}
	}

	public virtual void Main()
	{
	}
}
