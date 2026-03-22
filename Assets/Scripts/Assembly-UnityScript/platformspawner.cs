using System;
using UnityEngine;

[Serializable]
public class platformspawner : MonoBehaviour
{
	public GameObject largeSpace;

	public GameObject normalTwo;

	public GameObject space;

	public GameObject raised;

	public GameObject ridgeLeft;

	public GameObject ridgeRight;

	public GameObject twoPieceSlide;

	public GameObject fourPieceSlide;

	public GameObject specialJumpSlide;

	public int startSpawnPosition;

	public int spawnYPos;

	private int randomChoice;

	private int lastPosition;

	private GameObject cam;

	private bool canSpawn;

	public platformspawner()
	{
		startSpawnPosition = 20;
		spawnYPos = -8;
		canSpawn = true;
	}

	public virtual void Start()
	{
		lastPosition = startSpawnPosition;
		cam = GameObject.Find("Main Camera");
	}

	public virtual void Update()
	{
		if (!(cam.transform.position.x < (float)(lastPosition - 16)) && canSpawn)
		{
			canSpawn = false;
			randomChoice = UnityEngine.Random.Range(1, 16);
			spawnObject(randomChoice);
		}
	}

	public virtual void spawnObject(int rand)
	{
		if (rand >= 1 && rand <= 2)
		{
			UnityEngine.Object.Instantiate(largeSpace, new Vector3(lastPosition + 6, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 12;
		}
		if (rand >= 3 && rand <= 4)
		{
			UnityEngine.Object.Instantiate(normalTwo, new Vector3(lastPosition + 2, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 4;
		}
		if (rand >= 5 && rand <= 6)
		{
			UnityEngine.Object.Instantiate(space, new Vector3(lastPosition + 4, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 8;
		}
		if (rand >= 7 && rand <= 8)
		{
			UnityEngine.Object.Instantiate(raised, new Vector3(lastPosition + 2, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 4;
		}
		if (rand >= 9 && rand <= 10)
		{
			UnityEngine.Object.Instantiate(ridgeLeft, new Vector3(lastPosition + 2, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 4;
		}
		if (rand >= 11 && rand <= 12)
		{
			UnityEngine.Object.Instantiate(ridgeRight, new Vector3(lastPosition + 2, spawnYPos, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 4;
		}
		if (rand == 13)
		{
			UnityEngine.Object.Instantiate(twoPieceSlide, new Vector3(lastPosition + 4, spawnYPos + 8, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 8;
		}
		if (rand == 14)
		{
			UnityEngine.Object.Instantiate(fourPieceSlide, new Vector3(lastPosition + 6, spawnYPos + 8, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 12;
		}
		if (rand == 15)
		{
			UnityEngine.Object.Instantiate(specialJumpSlide, new Vector3(lastPosition + 8, spawnYPos + 8, 0f), Quaternion.Euler(0f, 0f, 0f));
			lastPosition += 16;
		}
		canSpawn = true;
	}

	public virtual void Main()
	{
	}
}
