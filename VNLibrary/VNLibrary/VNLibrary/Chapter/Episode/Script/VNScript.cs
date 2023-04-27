using System;
using System.Text;

namespace VNLibrary
{
	public class VNScript : IVNParsable
	{
		private string speaker = "_ignore_";
		private string message = string.Empty;
		private List<ScriptCommand> commandList = new List<ScriptCommand>();

		private int _commandIndex = 0;

		public string Speaker => speaker;
		public string Message => message;

		public VNScript(string _Speaker, string _Message, List<ScriptCommand> _ScriptCommand)
		{
			// default script type

			speaker = _Speaker;
			message = _Message;
			commandList = _ScriptCommand;
		}

		public VNScript(List<ScriptCommand> _ScriptCommand)
		{
			// effect script type
			commandList = _ScriptCommand;
		}

		public void ExecuteCommands()
		{
			foreach (ScriptCommand command in commandList)
			{
				command.Excute();
			}
		}

        #region interface implements

		public string Stringify()
		{
			return VNUtil.ScriptStringity(speaker, message);
		}

		public object Parse(string _SerializedData)
		{
			return null;
		}

        #endregion
    }
}