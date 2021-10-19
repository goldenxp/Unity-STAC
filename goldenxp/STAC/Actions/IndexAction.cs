namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Index Action")]
	public class IndexAction : MultiAction
	{
		public int index;
		
		public override void Run()
		{
			int actionCount = actions.Length;
			if (actionCount == 0 || index > actionCount)
				return;
			
			actions[index].Run();
		}
	}
}
