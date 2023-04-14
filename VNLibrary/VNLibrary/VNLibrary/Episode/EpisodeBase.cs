using System;
namespace VNLibrary.Episode
{
	// 클래스의 목적
	// 비주얼 노블이 아닌 다른 게임에서 사용될 때에는 배틀, 전투 등의 이벤트들이 발생
	// 해당 이벤트들을 모두 하나의 에피소드로 간주하여 사용하도록 하기 위함
	// 기존의 스토리를 진행하는 에피소드는 ScriptEpisode로 명명

	public abstract class EpisodeBase : IVNParsable
	{
		public event Action<int> OnEpisodeEvent = delegate { };

		public virtual bool HasEndEpisode => false;

		public void Open()
		{

		}

		public abstract string Stringify();

		protected abstract void Initialize();
    }
}

