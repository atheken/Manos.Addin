using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace MonoDevelop.Manos.Addin
{
	public class Runner : CommandHandler
	{
		public Runner ()
		{
		}
		
		protected override void Run ()
        {
        }
       
        protected override void Update (CommandInfo info)
        {
			if(IdeApp.Workbench.ActiveDocument.HasProject)
			{
				 //Console.WriteLine(IdeApp.Workbench.ActiveDocument.Project.Name);
			}
        }   
		
	}
	
	public enum ManosCommands{
		Run,	
	}
}

