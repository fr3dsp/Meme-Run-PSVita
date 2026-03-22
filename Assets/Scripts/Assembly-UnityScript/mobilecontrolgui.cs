using System;
using UnityEngine;

[Serializable]
public class mobilecontrolgui : MonoBehaviour
{
	private float lifeCounter;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		lifeCounter += Time.deltaTime;
		if (!(lifeCounter <= 1.25f))
		{
			float a = GetComponent<GUITexture>().color.a - Time.deltaTime / 2f;
			Color color = GetComponent<GUITexture>().color;
			float num = (color.a = a);
			Color color2 = (GetComponent<GUITexture>().color = color);
		}
		if (!(GetComponent<GUITexture>().color.a > 0f))
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
