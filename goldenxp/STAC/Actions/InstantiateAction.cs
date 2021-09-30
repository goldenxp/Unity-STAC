namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Instantiate Action")]
	[HelpURL("https://github.com/goldenxp/Unity-STAC/wiki/InstantiateAction")]
	public class InstantiateAction : SimpleActionBase
	{
		[Tooltip("GameObject that will be cloned.")]
		public GameObject prefab;
		
		[Tooltip("Time after which instantiated object is destroyed, only destroys if greater than zero")]
		public float destroyTime = 0f;
		
		public override void Run()
		{
			GameObject instance = Instantiate(prefab, transform.position, transform.rotation);
			if (destroyTime > 0)
			{
				Destroy(instance, destroyTime);
			}
		}
	}
}
