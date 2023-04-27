using System;

namespace VNLibrary
{
	// 클래스의 목적
	// 비주얼 노블이 아닌 다른 게임에서 사용될 때에는 배틀, 전투 등의 이벤트들이 발생
	// 해당 이벤트들을 모두 하나의 에피소드로 간주하여 사용하도록 하기 위함
	// 기존의 스토리를 진행하는 에피소드는 ScriptEpisode로 명명

	/// <summary>
	/// 모든 에피소드의 부모클래스입니다.
	/// </summary>
	public abstract class EpisodeBase : IVNParsable
	{
		/// <summary>
		/// 해당 에피소드가 종료되었는지 확인합니다.
		/// </summary>
		public virtual bool HasEndEpisode => false;

		/// <summary>
		/// 에피소드를 시작합니다.
		/// </summary>
		public void Open()
		{
			Initialize();
        }

		/// <summary>
		/// IVNParsable Implememnt</br>
		/// 해당 에피소드를 문자열로 직렬화합니다.
		/// </summary>
		/// <returns></returns>
		public abstract string Stringify();

		/// <summary>
		/// INVParsable Implement</br>
		/// 직렬화된 에피소드를 오브젝트로 반환합니다.
		/// </summary>
		/// <param name="_SerializedData"></param>
		/// <returns></returns>
		public abstract object Parse(string _SerializedData);

		/// <summary>
		/// 해당 에피소드를 초기화합니다.
		/// </summary>
		protected abstract void Initialize();
    }
}

