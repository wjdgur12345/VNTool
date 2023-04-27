using System;

namespace VNLibrary
{
    // 챕터는 여러 에피소드를 묶은 단위를 말함
    // 각각의 챕터는 하나의 파일이 되도록 저장
    // 게임 플레이의 실질적인 레벨의 시작점

    public abstract class ChapterBase : IVNParsable
    {
        protected List<EpisodeBase> episodeList = new List<EpisodeBase>();
        private int _episodeIndex = 0;

        public EpisodeBase CurrentEpisode
        {
            get
            {
                if (episodeList == null) return null;
                if (episodeList.Count <= 0) return null;
                if (episodeList.Count >= _episodeIndex) return null;

                return episodeList[_episodeIndex++];
            }
        }

        public abstract object Parse(string _SerializedString);
        public abstract string Stringify();
    }
}

