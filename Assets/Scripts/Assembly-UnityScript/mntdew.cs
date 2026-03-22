using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class mntdew : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024Start_002443 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal mntdew _0024self__002444;

			public _0024(mntdew self_)
			{
				_0024self__002444 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__002444.GetComponent<Renderer>().enabled = false;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__002444.derp = true;
					_0024self__002444.GetComponent<Renderer>().enabled = true;
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__002444.GetComponent<Renderer>().enabled = false;
					result = (Yield(4, new WaitForSeconds(38f)) ? 1 : 0);
					break;
				case 4:
					_0024self__002444.GetComponent<Renderer>().enabled = true;
					result = (Yield(5, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 5:
					_0024self__002444.GetComponent<Renderer>().enabled = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal mntdew _0024self__002445;

		public _0024Start_002443(mntdew self_)
		{
			_0024self__002445 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__002445);
		}
	}

	public bool derp;

	public virtual IEnumerator Start()
	{
		return new _0024Start_002443(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (derp)
		{
			transform.Rotate(0f, 0f, -10f);
		}
	}

	public virtual void Main()
	{
	}
}
