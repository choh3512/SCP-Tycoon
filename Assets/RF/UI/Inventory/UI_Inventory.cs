using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Inventory
{
    public class UI_Inventory : UI_Base
    {
        #region UI 오버라이드 함수
        public override void Initialize()
        {
            ui_Model = new UI_Inventory_Model();
            ui_Model.Initialize();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Inventory_View ui_View;
        private UI_Inventory_Model ui_Model;
        #endregion
    }
}
