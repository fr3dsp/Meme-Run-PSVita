using System;
using UnityEngine;

[Serializable]
public class flasher : MonoBehaviour
{
	public GameObject gameOverText;

	private bool gameOver;

	private bool isMenu;

	private GameObject player;

	public virtual void Start()
	{
		player = GameObject.Find("Player");
		if (player == null)
		{
			isMenu = true;
		}
		float a = 0.5f;
		Color color = GetComponent<GUITexture>().color;
		float num = (color.a = a);
		Color color2 = (GetComponent<GUITexture>().color = color);
	}

	public virtual void Update()
	{
		if (!isMenu)
		{
			if (!(GetComponent<GUITexture>().color.a <= 0f) && !gameOver)
			{
				float a = GetComponent<GUITexture>().color.a - Time.deltaTime / 2f;
				Color color = GetComponent<GUITexture>().color;
				float num = (color.a = a);
				Color color2 = (GetComponent<GUITexture>().color = color);
			}
			if (!(GetComponent<GUITexture>().color.a <= 0.35f) && gameOver)
			{
				float a2 = GetComponent<GUITexture>().color.a - Time.deltaTime / 2f;
				Color color4 = GetComponent<GUITexture>().color;
				float num2 = (color4.a = a2);
				Color color5 = (GetComponent<GUITexture>().color = color4);
			}
			if (!(GetComponent<GUITexture>().color.a > 0f) && GetComponent<GUITexture>().enabled && !gameOver)
			{
				GetComponent<GUITexture>().enabled = false;
			}
			if (!(GetComponent<GUITexture>().color.a <= 0f) && !GetComponent<GUITexture>().enabled && !gameOver)
			{
				GetComponent<GUITexture>().enabled = true;
			}
		}
		else if (!(GetComponent<GUITexture>().color.a <= 0.25f))
		{
			float a3 = GetComponent<GUITexture>().color.a - Time.deltaTime / 2f;
			Color color7 = GetComponent<GUITexture>().color;
			float num3 = (color7.a = a3);
			Color color8 = (GetComponent<GUITexture>().color = color7);
		}
	}

	public virtual void gameOverFlash()
	{
		float a = 0.5f;
		Color color = GetComponent<GUITexture>().color;
		float num = (color.a = a);
		Color color2 = (GetComponent<GUITexture>().color = color);
		GetComponent<GUITexture>().enabled = true;
		gameOver = true;
		int num2 = 0;
		Vector3 position = transform.position;
		float num3 = (position.z = num2);
		Vector3 vector = (transform.position = position);
		gameOverText.SetActive(true);
	}

	public virtual void Main()
	{
	}
}
