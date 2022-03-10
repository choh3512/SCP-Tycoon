using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Room
{
    public class UI_Shop_Room : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Room_Model();
            ui_Model.Initialize();
        }
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_Shop_Room_View ui_View;
        private UI_Shop_Room_Model ui_Model;
        #endregion
    }
}
