using System;
using System.Text;
using VNLibrary.Script;

namespace VNLibrary.Episode
{
	public class ScriptEpisode
	{
		private List<VNScript> scriptList = new List<VNScript>();

		public string Stringify()
		{
			StringBuilder sb = new StringBuilder();

			foreach(VNScript script in scriptList)
			{
				sb.AppendLine($"#{script.Stringify()}");
			}

			return sb.ToString();
		}
	}
}

