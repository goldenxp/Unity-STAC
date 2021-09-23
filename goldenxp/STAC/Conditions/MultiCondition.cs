namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Conditions/Multi Condition")]
	public class MultiCondition : SimpleConditionBase
	{
		public LogicOps op;
		public SimpleConditionBase[] conditions;
		public bool mustCheckAll = false;
		
		public override bool Check()
		{
			bool isAndOp = (op == LogicOps.AND);
			bool result = isAndOp; //  Default true for AND, false for OR
			foreach (var condition in conditions)
			{
				if (isAndOp)
				{
					result &= condition.Check();
					if (!mustCheckAll && !result)
							break;
				}
				else
				{
					result |= condition.Check();
					if (!mustCheckAll && result)
						break;
				}
			}
			
			return result;
		}
	}
}
