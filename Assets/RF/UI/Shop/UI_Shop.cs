using RF.UI.Ingame;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Shop
{
    public class UI_Shop : UI_Base
    {
        #region UI 오버라이드

        public override void Initialize()
        {
            Setup_Buttons();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Shop_View ui_View;
        private UI_Shop_Model ui_Model;
        #endregion
        
        #region UI Ingame
        [Title("인게임 UI")] 
        [SerializeField] private UI_Ingame ui_Ingame;
        #endregion
        
        #region 닫기
        [Title("버튼")] 
        [SerializeField] private Button close_Btn;

        private void Setup_Buttons()
        {
            close_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);
                ui_Ingame.gameObject.SetActive(true);
            });
        }
        #endregion
    }
}
