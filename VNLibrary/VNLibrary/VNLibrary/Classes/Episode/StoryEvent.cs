using System;
namespace VNLibrary
{
	/// <summary>
	/// 해당 클래스는 스토리 다이얼로그 각각을 구현하면서도 보상, 전투와 같은 이벤트를 하나의 부모클래스로부터 상속받아 사용하기 위함입니다.
	/// 이렇게 사용함으로서 모든 에피소드를 여러개의 스토리이벤트로 묶어서 관리하게 됩니다.
	/// </summary>
	public abstract class StoryEventBase
	{
		protected abstract string Speaker { get; }
		protected abstract string Dialogue { get; }
		protected List<StoryCommand> commandList = new List<StoryCommand>();
	}
}

