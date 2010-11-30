using System;
using MonoDevelop.Ide;
using MonoDevelop.Components;
using MonoDevelop.Core.Execution;

namespace Manos.Addin
{
	public class ManosExecutionCommand : ExecutionCommand
	{
		public ManosExecutionCommand ()
		{
		}
		
		public override string CommandString {
			get {
				return "[manos]";
			}
		}
	}
}

