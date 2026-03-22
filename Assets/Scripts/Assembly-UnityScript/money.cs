using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class money : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Start_002446 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal money _0024self__002447;

			public _0024(money self_)
			{
				_0024self__002447 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					Time.timeScale = 1f;
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(3, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(4, new WaitForSeconds(8f)) ? 1 : 0);
					break;
				case 4:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(5, new WaitForSeconds(8f)) ? 1 : 0);
					break;
				case 5:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(6, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 6:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(7, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 7:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(8, new WaitForSeconds(12f)) ? 1 : 0);
					break;
				case 8:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(9, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 9:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(10, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 10:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(11, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 11:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(12, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 12:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(13, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 13:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(14, new WaitForSeconds(11.5f)) ? 1 : 0);
					break;
				case 14:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(15, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 15:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(16, new WaitForSeconds(8f)) ? 1 : 0);
					break;
				case 16:
					_0024self__002447.GetComponent<Renderer>().enabled = true;
					result = (Yield(17, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 17:
					_0024self__002447.GetComponent<Renderer>().enabled = false;
					result = (Yield(18, new WaitForSeconds(46f)) ? 1 : 0);
					break;
				case 18:
					_0024self__002447.restart();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal money _0024self__002448;

		public _0024Start_002446(money self_)
		{
			_0024self__002448 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002448);
		}
	}

	public Texture quk1;

	public Texture quk2;

	public Texture quk3;

	public Texture quk4;

	public Texture quk5;

	public Texture quk6;

	public Texture quk7;

	private float counter;

	public virtual IEnumerator Start()
	{
		return new _0024Start_002446(this).GetEnumerator();
	}

	public virtual void restart()
	{
		StartCoroutine(Start());
	}

	public virtual void Update()
	{
		counter += Time.deltaTime * 30f;
		if (!(counter <= 0f) && !(counter >= 1f) && GetComponent<Renderer>().material.mainTexture != quk1)
		{
			GetComponent<Renderer>().material.mainTexture = quk1;
		}
		if (!(counter <= 1f) && !(counter >= 2f) && GetComponent<Renderer>().material.mainTexture != quk2)
		{
			GetComponent<Renderer>().material.mainTexture = quk2;
		}
		if (!(counter <= 2f) && !(counter >= 3f) && GetComponent<Renderer>().material.mainTexture != quk3)
		{
			GetComponent<Renderer>().material.mainTexture = quk3;
		}
		if (!(counter <= 3f) && !(counter >= 4f) && GetComponent<Renderer>().material.mainTexture != quk4)
		{
			GetComponent<Renderer>().material.mainTexture = quk4;
		}
		if (!(counter <= 4f) && !(counter >= 5f) && GetComponent<Renderer>().material.mainTexture != quk5)
		{
			GetComponent<Renderer>().material.mainTexture = quk5;
		}
		if (!(counter <= 5f) && !(counter >= 6f) && GetComponent<Renderer>().material.mainTexture != quk6)
		{
			GetComponent<Renderer>().material.mainTexture = quk6;
		}
		if (!(counter <= 6f) && !(counter >= 7f) && GetComponent<Renderer>().material.mainTexture != quk7)
		{
			GetComponent<Renderer>().material.mainTexture = quk7;
		}
		if (!(counter <= 7f))
		{
			counter = 0f;
		}
	}

	public virtual void Main()
	{
	}
}
