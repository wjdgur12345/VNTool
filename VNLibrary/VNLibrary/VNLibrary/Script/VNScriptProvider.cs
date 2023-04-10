using System;
namespace VNLibrary.Script
{
	public class ScriptProvider
	{
		// 하나의 스크립트 제공자는 하나의 챕터단위로 스크립트를 파싱하며 제공합

		private List<VNScript> scriptList = new List<VNScript>();

		private VNScript _currentscript = null;

		public void ScriptProviderInitialize()
		{
			// not implements
		}
	}
}

