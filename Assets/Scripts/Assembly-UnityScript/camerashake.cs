using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class camerashake : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024derp_002431 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal camerashake _0024self__002432;

			public _0024(camerashake self_)
			{
				_0024self__002432 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(3, new WaitForSeconds(2.75f)) ? 1 : 0);
					break;
				case 3:
					UnityEngine.Object.Instantiate(_0024self__002432.quickscope, new Vector3(64f, -4f, -3f), Quaternion.identity);
					UnityEngine.Object.Instantiate(_0024self__002432.hitmarkers, new Vector3(69f, 0f, -3f), Quaternion.identity);
					result = (Yield(4, new WaitForSeconds(1.75f)) ? 1 : 0);
					break;
				case 4:
					UnityEngine.Object.Instantiate(_0024self__002432.quickscope, new Vector3(88f, -4f, -3f), Quaternion.identity);
					UnityEngine.Object.Instantiate(_0024self__002432.hitmarkers, new Vector3(92f, 0f, -3f), Quaternion.identity);
					result = (Yield(5, new WaitForSeconds(1.25f)) ? 1 : 0);
					break;
				case 5:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(6, new WaitForSeconds(6.25f)) ? 1 : 0);
					break;
				case 6:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(7, new WaitForSeconds(5.75f)) ? 1 : 0);
					break;
				case 7:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(8, new WaitForSeconds(8.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(9, new WaitForSeconds(4.75f)) ? 1 : 0);
					break;
				case 9:
					UnityEngine.Object.Instantiate(_0024self__002432.quickscope, new Vector3(420f, -4f, -3f), Quaternion.identity);
					UnityEngine.Object.Instantiate(_0024self__002432.hitmarkers, new Vector3(430f, 0f, -3f), Quaternion.identity);
					result = (Yield(10, new WaitForSeconds(12.75f)) ? 1 : 0);
					break;
				case 10:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(11, new WaitForSeconds(14.25f)) ? 1 : 0);
					break;
				case 11:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					result = (Yield(12, new WaitForSeconds(8.75f)) ? 1 : 0);
					break;
				case 12:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("1");
					result = (Yield(13, new WaitForSeconds(25.25f)) ? 1 : 0);
					break;
				case 13:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("2");
					result = (Yield(14, new WaitForSeconds(9.75f)) ? 1 : 0);
					break;
				case 14:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("3");
					result = (Yield(15, new WaitForSeconds(4.75f)) ? 1 : 0);
					break;
				case 15:
					UnityEngine.Object.Instantiate(_0024self__002432.quickscope, new Vector3(1330f, -4f, -3f), Quaternion.identity);
					UnityEngine.Object.Instantiate(_0024self__002432.hitmarkers, new Vector3(1340f, 0f, -3f), Quaternion.identity);
					MonoBehaviour.print("4");
					result = (Yield(16, new WaitForSeconds(4.25f)) ? 1 : 0);
					break;
				case 16:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("5");
					result = (Yield(17, new WaitForSeconds(9f)) ? 1 : 0);
					break;
				case 17:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("6");
					result = (Yield(18, new WaitForSeconds(11.5f)) ? 1 : 0);
					break;
				case 18:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("7");
					result = (Yield(19, new WaitForSeconds(7.5f)) ? 1 : 0);
					break;
				case 19:
					_0024self__002432.StartCoroutine(_0024self__002432.Shake());
					MonoBehaviour.print("8");
					result = (Yield(20, new WaitForSeconds(6.25f)) ? 1 : 0);
					break;
				case 20:
					_0024self__002432.restart();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal camerashake _0024self__002433;

		public _0024derp_002431(camerashake self_)
		{
			_0024self__002433 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002433);
		}
	}

	[Serializable]
	internal sealed class _0024Start_002434 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal camerashake _0024self__002435;

			public _0024(camerashake self_)
			{
				_0024self__002435 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					GameObject.Find("airhornstatic").GetComponent<GUITexture>().enabled = false;
					_0024self__002435.StartCoroutine(_0024self__002435.derp());
					result = (Yield(2, new WaitForSeconds(37f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002435.ShakeCustom();
					result = (Yield(3, new WaitForSeconds(7f)) ? 1 : 0);
					break;
				case 3:
					_0024self__002435.ShakeCustom();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal camerashake _0024self__002436;

		public _0024Start_002434(camerashake self_)
		{
			_0024self__002436 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002436);
		}
	}

	[Serializable]
	internal sealed class _0024Shake_002437 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal camerashake _0024self__002438;

			public _0024(camerashake self_)
			{
				_0024self__002438 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002438.originRotation = _0024self__002438.transform.rotation;
					_0024self__002438.shake_intensity = 0.3f;
					_0024self__002438.shake_decay = 0.002f;
					GameObject.Find("airhornstatic").GetComponent<GUITexture>().enabled = true;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					GameObject.Find("airhornstatic").GetComponent<GUITexture>().enabled = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal camerashake _0024self__002439;

		public _0024Shake_002437(camerashake self_)
		{
			_0024self__002439 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002439);
		}
	}

	public Vector3 originPosition;

	public Quaternion originRotation;

	public float shake_decay;

	public float shake_intensity;

	public GUITexture airhornstatic;

	public GameObject hitmarkers;

	public GameObject quickscope;

	public virtual void restart()
	{
		StartCoroutine(derp());
	}

	public virtual IEnumerator derp()
	{
		return new _0024derp_002431(this).GetEnumerator();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_002434(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!(shake_intensity <= 0f))
		{
			transform.rotation = new Quaternion(originRotation.x + UnityEngine.Random.Range(0f - shake_intensity, shake_intensity) * 0.2f, originRotation.y + UnityEngine.Random.Range(0f - shake_intensity, shake_intensity) * 0.2f, originRotation.z + UnityEngine.Random.Range(0f - shake_intensity, shake_intensity) * 0.2f, originRotation.w + UnityEngine.Random.Range(0f - shake_intensity, shake_intensity) * 0.2f);
			shake_intensity -= shake_decay;
		}
	}

	public virtual void ShakeCustom()
	{
		originRotation = transform.rotation;
		shake_intensity = 0.3f;
		shake_decay = 0.002f;
	}

	public virtual IEnumerator Shake()
	{
		return new _0024Shake_002437(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
