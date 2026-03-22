using System;
using UnityEngine;

[Serializable]
public class loader : MonoBehaviour
{
	public virtual void Start()
	{
		Application.targetFrameRate = 60;
		#if UNITY_WIIU
		WiiUDuplicateSound.StartDuplicatingSoundToGamePad();
		#endif
		Application.LoadLevel("menu");
	}

	public virtual void Main()
	{
	}
}
