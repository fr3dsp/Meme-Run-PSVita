using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class cloud : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Start_002440 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal cloud _0024self__002441;

			public _0024(cloud self_)
			{
				_0024self__002441 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002441.GetComponent<Renderer>().enabled = false;
					result = (Yield(2, new WaitForSeconds(42f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002441.GetComponent<Renderer>().enabled = true;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal cloud _0024self__002442;

		public _0024Start_002440(cloud self_)
		{
			_0024self__002442 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002442);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_002440(this).GetEnumerator();
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}
