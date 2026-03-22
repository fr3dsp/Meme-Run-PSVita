using System;
using UnityEngine;

[Serializable]
public class highscore : MonoBehaviour
{
	public virtual void Start()
	{
		GetComponent<GUIText>().text = "HIGHSCORE: " + PlayerPrefs.GetFloat("highscore").ToString();
	}

	public virtual void updateScore()
	{
		GetComponent<GUIText>().text = "HIGHSCORE: " + PlayerPrefs.GetFloat("highscore").ToString();
	}

	public virtual void Main()
	{
	}
}
