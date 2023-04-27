using System;
using System.Text;

namespace VNLibrary
{
    // 스크립트들로 이루어진 스토리 에피소

	public class ScriptEpisode : EpisodeBase
	{
		private List<VNScript> scriptList = new List<VNScript>();

        #region EpisodeBase abstract method implements

        public override string Stringify()
        {
            StringBuilder sb = new StringBuilder();

            foreach (VNScript script in scriptList)
            {
                sb.AppendLine($"#{script.Stringify()}");
            }

            return sb.ToString();
        }

        public override object Parse(string _SerializeData)
        {
            return null;


        }

        protected override void Initialize()
        {
            Console.WriteLine("Script Episode need initialize implement...");
        }

        #endregion
    }
}

