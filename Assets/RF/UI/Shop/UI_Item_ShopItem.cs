using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop
{
    public class UI_Item_ShopItem : UI_Item_Base
    {
        #region UI 오버라이드 함수
        public override void Initialize()
        {
           
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Item_ShopItem_View ui_View;

        public UI_Item_ShopItem_View GetView()
        {
            return ui_View;
        }
        #endregion
    }
}
