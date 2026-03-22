using System;
using UnityEngine;
#if UNITY_WIIU
using WiiU = UnityEngine.WiiU;
#endif

[Serializable]
public class menu : MonoBehaviour
{
	private GUILayer guiSelect;

	private bool touching;

#if UNITY_WIIU
	public WiiU.GamePad myGP;
#endif
	public virtual void Start()
	{
		guiSelect = (GUILayer)Camera.main.GetComponent(typeof(GUILayer));
	}

	public virtual void Update()
	{
	#if UNITY_WIIU
		myGP = WiiU.GamePad.access;
		WiiU.GamePadState gamePad = myGP.state;
	#endif
		#if !UNITY_EDITOR && UNITY_WIIU
		if (gamePad.IsPressed(WiiU.GamePadButton.X))
		{
			Application.LoadLevel("game");
		}
		if (gamePad.IsPressed(WiiU.GamePadButton.B))
		{
			Application.LoadLevel("Bigley");
		}
		#else
		if (Input.GetKeyDown(KeyCode.X))
		{
			Application.LoadLevel("game");
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			Application.LoadLevel("Bigley");
		}
		#endif
	}

	public virtual void Main()
	{
	}
}
