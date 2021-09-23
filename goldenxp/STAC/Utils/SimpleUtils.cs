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
	
	public class Utils
	{
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
