// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.
/*--- __ECO__ __ACTION__ ---*/

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Returns the smallest integer greater to or equal to f.")]
	public class FloatCeiling : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
        [Tooltip("The Float variable to process.")]
		public FsmFloat floatVariable;

		[UIHint(UIHint.Variable)]
		[Tooltip("The float result.")]
		public FsmFloat floatResult;

		[UIHint(UIHint.Variable)]
		[Tooltip("The int result.")]
		public FsmInt intResult;

        [Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		public override void Reset()
		{
			floatVariable = null;
			floatResult = null;
			intResult = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoMath();
			
			if (!everyFrame)
			{
			    Finish();
			}
		}

		public override void OnUpdate()
		{
			DoMath();
		}
		
		void DoMath()
		{
			if (floatResult.Value != null)
			{
				floatResult.Value = (Mathf.Ceil(floatVariable.Value));
			}

			if (intResult.Value != null)
			{
				intResult.Value = (Mathf.CeilToInt(floatVariable.Value));
			}
		}
	}
}





