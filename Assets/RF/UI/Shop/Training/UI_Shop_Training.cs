using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Training
{
    public class UI_Shop_Training : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Training_Model();
            ui_Model.Initialize();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Shop_Training_View ui_View;
        private UI_Shop_Training_Model ui_Model;
        #endregion
    }
}
