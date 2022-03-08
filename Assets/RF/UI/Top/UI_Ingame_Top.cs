using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Top
{
    public class UI_Ingame_Top : UI_Base
    {
        #region UI 오버라이드 함수

        public override void Initialize()
        {
            ui_Model = new UI_Ingame_Top_Model();
            ui_Model.Initialize();
        }

        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Ingame_Top_View ui_View;
        [SerializeField] private UI_Ingame_Top_Model ui_Model;
        #endregion
    }
}
