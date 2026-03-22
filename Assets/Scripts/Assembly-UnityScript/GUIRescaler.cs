using System;
using UnityEngine;

[Serializable]
public class GUIRescaler : MonoBehaviour
{
	private Component getTxt;

	private Component getTxtr;

	private float resX;

	private float resY;

	private float origResX;

	private float origResY;

	private float txtrX;

	private float txtrY;

	private float txtX;

	private float txtY;

	public virtual void Start()
	{
		getTxt = (GUIText)transform.GetComponent(typeof(GUIText));
		getTxtr = (GUITexture)transform.GetComponent(typeof(GUITexture));
		if (getTxtr == null && getTxt == null)
		{
			MonoBehaviour.print("No GUIText or GUITexture exists on: " + transform.gameObject.name);
		}
	}

	public virtual void Update()
	{
		if ((float)Screen.width != origResX || (float)Screen.height != origResY)
		{
			origResX = Screen.width;
			origResY = Screen.height;
			if (getTxt != null)
			{
				resX = Screen.width;
				resY = Screen.height;
				txtX = transform.localScale.x;
				txtY = transform.localScale.y;
				float y = transform.localScale.x * (resX / resY);
				Vector3 localScale = transform.localScale;
				float num = (localScale.y = y);
				Vector3 vector = (transform.localScale = localScale);
			}
			if (getTxtr != null)
			{
				resX = Screen.width;
				resY = Screen.height;
				txtrX = transform.GetComponent<GUITexture>().texture.width;
				txtrY = transform.GetComponent<GUITexture>().texture.height;
				float y2 = transform.localScale.x * (resX / resY) / (txtrX / txtrY);
				Vector3 localScale2 = transform.localScale;
				float num2 = (localScale2.y = y2);
				Vector3 vector3 = (transform.localScale = localScale2);
			}
		}
	}

	public virtual void Main()
	{
	}
}
