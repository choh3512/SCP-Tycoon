using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Misc
{
    public class UI_Shop_Misc : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Misc_Model();
            ui_Model.Initialize();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Shop_Misc_View ui_View;
        private UI_Shop_Misc_Model ui_Model;
        #endregion
    }
}
