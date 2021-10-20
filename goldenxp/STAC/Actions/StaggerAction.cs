namespace goldenxp
{
	using System.Collections;
	using UnityEngine;
	
	[AddComponentMenu("STAC/Actions/Runners/Stagger Action")]
	[HelpURL(Utils.HelpURL + "StaggerAction")]
	public class StaggerAction : MultiAction
	{
		public int[] delays;
		
		public override void Run()
		{
			StartCoroutine("RunActions");
		}
		
		IEnumerator RunActions()
		{
			int actionCount = actions.Length;
			int delayCount = delays.Length;
			for (int i = 0; i < actionCount; i++)
			{
				var delay = delays[(i < actionCount-1) ? i : delayCount-1];
				yield return new WaitForSeconds(delay);
				actions[i].Run();
			}
		}
		
	}
}
