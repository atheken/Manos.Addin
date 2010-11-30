using System;
using MonoDevelop.Ide;
using MonoDevelop.Projects;
using MonoDevelop.Core.Execution;
using System.Linq;

namespace Manos.Addin
{
	public class ManosProjectExtensions : ProjectServiceExtension
	{
		public ManosProjectExtensions ()
		{
		}
		
		public override bool CanExecute (IBuildTarget item, ExecutionContext context, ConfigurationSelector configuration)
		{
			var retval = false;
			if(item is DotNetProject)
			{
				var p = item as DotNetProject;
				retval = p.References.Any(y=>y.Reference.Contains("manos"));
			}
			return retval || base.CanExecute(item,context, configuration);
		}
		
		protected override void Execute (MonoDevelop.Core.IProgressMonitor monitor, SolutionEntityItem item,
		                                 ExecutionContext context, ConfigurationSelector configuration)
		{
//			base.Execute (monitor, item, context, configuration);
		}
		
	}
}

