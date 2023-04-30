using System;

namespace VNLibrary
{
    public enum EventType { Stroy, StoryAndBattle, Battle, Reword }

	public abstract class EpisodeDataDescriptorBase
	{
		public abstract string EventType { get; }
		public abstract string Content { get; }
	}

	public class BattleEpisodeDescriptor : EpisodeDataDescriptorBase
	{
        public override string EventType => "Battle";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

		public BattleEpisodeDescriptor(string _Target)
		{
			_targetContent = _Target;
		}
    }

    public class StoryEpisodeDescriptor : EpisodeDataDescriptorBase
    {
        public override string EventType => "Story";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public StoryEpisodeDescriptor(string _Target)
        {
            _targetContent = _Target;
        }
    }

    public class StoryAndBattleEpisodeDescriptor : EpisodeDataDescriptorBase
    {
        public override string EventType => "StoryAndBattle";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public StoryAndBattleEpisodeDescriptor(string _Target)
        {
            _targetContent = _Target;
        }
    }

    public class RewordEpisodeDescriptor : EpisodeDataDescriptorBase
    {

        public override string EventType => "Reword";
        public override string Content => _targetContent;

        private string _targetContent = string.Empty;

        public RewordEpisodeDescriptor(string _Target)
        {
            _targetContent = _Target;
        }
    }

}

