using System;

namespace VNLibrary
{
	public abstract class EpisodeDataBase
	{
		public abstract string EventType { get; }
		public abstract string Content { get; }
	}

	public class BattleEpisodeData : EpisodeDataBase
	{
        public override string EventType => "Battle";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

		public BattleEpisodeData(string _Target)
		{
			_targetContent = _Target;
		}
    }

    public class StoryEpisodeData : EpisodeDataBase
    {

        public override string EventType => "Story";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public StoryEpisodeData(string _Target)
        {
            _targetContent = _Target;
        }
    }

    public class StoryAndBattleEpisodeData : EpisodeDataBase
    {

        public override string EventType => "StoryAndBattle";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public StoryAndBattleEpisodeData(string _Target)
        {
            _targetContent = _Target;
        }
    }

    public class RewordEpisodeData : EpisodeDataBase
    {

        public override string EventType => "Reword";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public RewordEpisodeData(string _Target)
        {
            _targetContent = _Target;
        }
    }

}

