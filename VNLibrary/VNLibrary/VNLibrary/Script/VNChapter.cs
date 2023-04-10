using System;
namespace VNLibrary.Script
{
	public class VNChapter
	{
		private List<VNScript> scriptList = null;

		private int _scriptIndex = 0;
		public VNScript _currentScript = null;

		public VNChapter(List<VNScript> _ScriptList)
		{
			scriptList = _ScriptList;
		}

		public VNScript NextScript()
		{
			if (scriptList == null) return null;
			if (_currentScript != null) return null;

			return scriptList[_scriptIndex];

		}
	}
}

