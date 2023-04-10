using System;
using System.Text;

namespace VNLibrary.Script
{
	public class VNScript : IVNParsable
	{
		private string speaker = "_ignore_";
		private string message = string.Empty;
		private List<ScriptCommad> commandList = new List<ScriptCommad>();

		private int _commandIndex = 0;

		public string Speaker => speaker;
		public string Message => message;

		public VNScript(string _Speaker, string _Message, List<ScriptCommad> _ScriptCommand)
		{
			// default script type

			speaker = _Speaker;
			message = _Message;
			commandList = _ScriptCommand;
		}

		public VNScript(List<ScriptCommad> _ScriptCommand)
		{
			// effect script type

			commandList = _ScriptCommand;
		}

		public ScriptCommad NextCommand()
		{
			if (commandList == null || commandList.Count <= 0) return new ScriptEndCommand();
			if (_commandIndex >= commandList.Count) return new ScriptEndCommand();

            ScriptCommad nextCommand = commandList[_commandIndex];

			_commandIndex++;

			return nextCommand;
		}

        #region interface implements

		public string Stringify()
		{
			return VNUtil.ScriptStringity(speaker, message);
		}

        #endregion
    }
}