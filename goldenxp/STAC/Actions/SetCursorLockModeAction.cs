namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	using System;
	
	[AddComponentMenu("STAC/Actions/Set Cursor Lock Mode Action")]
	[HelpURL(Utils.HelpURL + "SetCursorLockModeAction")]
	public class SetCursorLockModeAction : SimpleActionBase
	{
		public CursorLockMode mode;
		public bool cursorVisibility;
		
		public override void Run()
		{
			Cursor.visible = cursorVisibility;
			Cursor.lockState = mode;
		}
	}
}
