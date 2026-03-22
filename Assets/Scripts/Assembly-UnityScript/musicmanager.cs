using System;
using UnityEngine;

[Serializable]
public class musicmanager : MonoBehaviour
{
	public virtual void Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}

	public virtual void Main()
	{
	}
}
