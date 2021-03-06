// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.
/*--- __ECO__ __ACTION__ ---*/

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Vector2")]
	[Tooltip("Reverses the direction of a Vector2 Variable. Same as multiplying by -1.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W1015")]
	public class Vector2Invert : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector to invert")]
		public FsmVector2 vector2Variable;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		public override void Reset()
		{
			vector2Variable = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			vector2Variable.Value = vector2Variable.Value * -1;
			
			if (!everyFrame)
				Finish();		
		}

		public override void OnUpdate()
		{
			vector2Variable.Value = vector2Variable.Value *  -1;
		}
	}
}

