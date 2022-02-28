using System.Collections.Generic;
using UniRx;

namespace RF.UI.Loading
{
    public class UI_LoadingScreen_Model
    {
        #region 초기화
        public void Initialize()
        {
            
        }
        #endregion
        
        #region 로딩 데이터
        public FloatReactiveProperty progress = new FloatReactiveProperty(0);
        #endregion
    
        #region 팁 데이터
        public Dictionary<string, string> tip_Texts = new Dictionary<string, string>();

        private void Setup_Tips()
        {
            tip_Texts.Add("tip_1", "이 게임은 SCP 스토리를 기반으로 만들어진 게임입니다");
            tip_Texts.Add("tip_2", "SCP의 종류를 알고 있다면 게임을 플레이하기 수월합니다.");
            tip_Texts.Add("tip_3", "각 SCP에 따른 격리 방법이 존재합니다.");
            tip_Texts.Add("tip_4", "NTF 가드, 클래스 D, 연구원을 훈련하여 더 좋은 효율을 내보세요!");
        }
        #endregion
    }
}
