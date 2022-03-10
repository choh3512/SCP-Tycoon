using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Research
{
    public class UI_Shop_Research : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Research_Model();
            ui_Model.Initialize();
        }
        #endregion
        
        #region MVP

        [Title("MVP")] 
        [SerializeField] private UI_Shop_Research_View ui_view;
        private UI_Shop_Research_Model ui_Model;

        #endregion
    }
}
