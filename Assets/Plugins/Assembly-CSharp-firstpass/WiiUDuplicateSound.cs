using System.Runtime.InteropServices;

public class WiiUDuplicateSound
{
	private static bool initialized;

	[DllImport("DuplicateSound")]
	private static extern void DuplicateSound_Init();

	public static void StartDuplicatingSoundToGamePad()
	{
		if (!initialized)
		{
			DuplicateSound_Init();
			initialized = true;
		}
	}
}
