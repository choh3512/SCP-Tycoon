using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Movement
{
    public class UI_Shop_Movement : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Movement_Model();
            ui_Model.Initialize();
        }

        #endregion
        
        #region MVP

        [Title("MVP")] 
        [SerializeField] private UI_Shop_Movement_View ui_view;
        private UI_Shop_Movement_Model ui_Model;
        #endregion
    }
}
