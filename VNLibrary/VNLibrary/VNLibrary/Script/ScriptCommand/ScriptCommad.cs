using System;
using VNLibrary.Command;

namespace VNLibrary.Script
{
	public abstract class ScriptCommad : VNCommand
	{
		public virtual bool ScriptBreak => false;
	}

    public class ScriptEndCommand : ScriptCommad
    {
        public override bool ScriptBreak => true;

        public override void Excute()
        {
            Console.WriteLine("Script Break");
        }
    }
}

