namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.InputSystem;
	
	[AddComponentMenu("STAC/Triggers/Input Action Trigger")]
	public class InputActionEventsTrigger : SimpleTriggerBase
	{
		public InputActionReference input;
		public SimpleActionBase performAction;
		public SimpleActionBase startAction;
		public SimpleActionBase cancelAction;
		
		public void OnEnable()
		{
			if (input == null) return;
			InputAction inpa = input.action;
			if (inpa == null) return;
			inpa.Enable();
			if (startAction != null) inpa.started += OnInputStarted;
			if (performAction != null) inpa.performed += OnInputPerformed;
			if (cancelAction != null) inpa.canceled += OnInputCanceled;
		}
		
		public void OnDisable()
		{
			if (input == null) return;
			InputAction inpa = input.action;
			if (inpa == null) return;
			inpa.Disable();
			if (startAction != null) inpa.started -= OnInputStarted;
			if (performAction != null) inpa.performed -= OnInputPerformed;
			if (cancelAction != null) inpa.canceled -= OnInputCanceled;
		}
		
		protected void OnInputStarted(InputAction.CallbackContext ctx)
		{
			startAction.Run();
		}
		
		protected void OnInputPerformed(InputAction.CallbackContext ctx)
		{
			performAction.Run();
		}
		
		protected void OnInputCanceled(InputAction.CallbackContext ctx)
		{
			cancelAction.Run();
		}
	}
}