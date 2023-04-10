using System;
namespace VNLibrary
{
	public partial class VNUtil
	{
		public static string ScriptStringity(string _Speaker, string _Message)
		{
			return $"{_Speaker}:{_Message}";
		}

		public Script.VNScript ParseScript(string _StringityText)
		{
			Console.WriteLine("not implement");
			throw new NotImplementedException();
		}
	}
}

