namespace goldenxp
{
	using System.Collections;
	using UnityEngine;
	
	[AddComponentMenu("STAC/Actions/Change Color Action")]
	[HelpURL(Utils.HelpURL + "ChangeColorAction")]
	public class ChangeColorAction : SimpleActionBase
	{
		public Color color;
		public GameObject target;
		public float duration = 0f;
		
		public override void Run()
		{
			StartCoroutine("LerpRendererColor");
		}
		
		IEnumerator LerpRendererColor()
		{
			float time = 0;
			Renderer renderer = target.GetComponent<Renderer>();
			Color original = renderer.material.color;
			while (time < duration)
			{
				renderer.material.color = Color.Lerp(original, color, time/duration);
				time += Time.deltaTime;
				yield return null;
			}
			renderer.material.color = color;
		}
	}
}
