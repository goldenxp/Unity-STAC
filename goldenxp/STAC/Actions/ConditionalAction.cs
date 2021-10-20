namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Runners/Conditional Action")]
	[HelpURL(Utils.HelpURL + "ConditionalAction")]
	public class ConditionalAction : SimpleActionBase
	{
		public SimpleConditionBase condition;
		public SimpleActionBase passAction;
		public SimpleActionBase failAction;
		
		public override void Run()
		{
			if (condition.Check())
			{
				passAction?.Run();
			}
			else
			{
				failAction?.Run();
			}
		}
	}
}
