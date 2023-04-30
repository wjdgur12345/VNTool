using System;
namespace VNLibrary
{
	public abstract class EpisodeData
	{
		protected List<StoryEventBase> storyEventList = new List<StoryEventBase>();
		protected int storyIndex = 0;

		public bool HasNaxt
		{
			get
			{
				if (storyEventList == null || storyEventList.Count <= 0) return false;
				if (storyEventList.Count <= storyIndex) return false;

				return true;
			}
		}

		public StoryEventBase NextEvent
		{
			get
			{
				if (!HasNaxt) return null;
				return storyEventList[storyIndex];
			}
		}

		public EpisodeData(string _PlainText)
		{
			ConversionFromText(_PlainText);
        }

		public abstract void ConversionFromText(string _PlainText);
	}

}

