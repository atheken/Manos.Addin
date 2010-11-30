using System;
using System.Collections.Generic;
using System.IO;
using MonoDevelop.Debugger;
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using Mono.Debugging.Client;
using MonoDevelop.Debugger.Soft;
using System.Net;
using MonoDevelop.Core.Assemblies;
using Mono.Debugging.Soft;


namespace Manos.Addin
{
	public class ManosDebuggerEngine : IDebuggerEngine
	{
		public ManosDebuggerEngine ()
		{
		}
		public bool CanDebugCommand (ExecutionCommand command)
		{
			//return cmd != null && SoftDebuggerEngine.CanDebugRuntime (cmd.TargetRuntime);
			return true;
		}

		FilePath GetFxDir (MonoTargetRuntime runtime, ClrVersion version)
		{
			FilePath prefix = runtime.Prefix;
			switch (version) {
			case ClrVersion.Net_1_1:
				return prefix.Combine ("lib", "mono", "1.0");
			case ClrVersion.Net_2_0:
				return prefix.Combine ("lib", "mono", "2.0");
			case ClrVersion.Net_4_0:
				return prefix.Combine ("lib", "mono", "4.0");
			}
			throw new InvalidOperationException (string.Format ("Unknown runtime version '{0}'", version));
		}

		public DebuggerStartInfo CreateDebuggerStartInfo (ExecutionCommand command)
		{
			
			return null;
		}
		
		
		public DebuggerSession CreateSession ()
		{
			return new SoftDebuggerSession();
		}

		public ProcessInfo[] GetAttachableProcesses ()
		{
			return new ProcessInfo[0];
		}

	}
}