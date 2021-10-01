namespace goldenxp
{
	public enum CompareOps
	{
		Greater,
		GreaterOrEquals,
		Equals,
		LessOrEquals,
		Less,
		NotEquals
	}
	
	public enum LogicOps
	{
		AND,
		OR
	}
	
	public class Utils
	{
		public const string HelpURL = "https://github.com/goldenxp/Unity-STAC/wiki/";
		
		public static bool Compare(CompareOps op, int left, int right)
		{
			switch (op)
			{
				case CompareOps.Greater: return left > right;
				case CompareOps.GreaterOrEquals: return left >= right;
				case CompareOps.Equals: return left == right;
				case CompareOps.Less: return left < right;
				case CompareOps.LessOrEquals: return left <= right;
				case CompareOps.NotEquals: return left != right;
				default: return false;
			}
		}
	}
}
