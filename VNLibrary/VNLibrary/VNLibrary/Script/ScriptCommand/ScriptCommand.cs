using System;
using VNLibrary.Command;

namespace VNLibrary.Script
{
	public abstract class ScriptCommand : VNCommand
	{
		public virtual bool ScriptBreak => false;
	}

    public class ScriptEndCommand : ScriptCommand
    {
        public override bool ScriptBreak => true;

        public override void Excute()
        {
            Console.WriteLine("Script Break");
        }
    }
}

