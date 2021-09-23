namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.SceneManagement;
	
	[AddComponentMenu("STAC/Actions/Load Scene Action")]
	public class LoadSceneAction : SimpleActionBase
	{
		public string sceneName;
		public LoadSceneMode mode;
		
		public override void Run()
		{
			SceneManager.LoadScene(sceneName, mode);
		}
		
		public void SetSceneName(string val)
		{
			sceneName = val;
		}
	}
}
