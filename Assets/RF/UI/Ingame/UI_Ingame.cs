using RF.UI.Base;
using RF.UI.Shop;
using RF.UI.Top;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Ingame
{
    public class UI_Ingame : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Ingame_Model();
            ui_Model.Initialize();

            Setup_Buttons();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Ingame_View ui_View;
        [SerializeField] private UI_Ingame_Model ui_Model;
        #endregion
        
        #region UI Ingame
        [Title("인게임 UI")]
        [SerializeField] private UI_Ingame_Top ui_Top;
        #endregion
        
        #region UI Shop
        [Title("상점 UI")] 
        [SerializeField] private UI_Shop ui_Shop;
        #endregion

        #region Buttons 
        [Title("버튼")]
        [SerializeField] private UI_Custom_Button shop_Btn;

        private void Setup_Buttons()
        {
            shop_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);
                ui_Shop.gameObject.SetActive(true);
            });
        }
        #endregion
        
        #region 인게임
        [Title("인게임")] 
        public RF.Ingame.Ingame ingame;
        #endregion
    }
}
