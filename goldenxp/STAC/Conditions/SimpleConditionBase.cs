namespace goldenxp
{
	using UnityEngine;
	
	[AddComponentMenu("")]
	public abstract class SimpleConditionBase : MonoBehaviour
	{
		public abstract bool Check();
	}
}