using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace RF.UI.Popup.ShopBuy
{
    public class UI_Popup_ShopBuy_View : UI_View_Base
    {
        #region 가격 
        [Title("가격")] 
        [SerializeField] private TMP_Text gold_Text;
        [SerializeField] private TMP_Text cash_Text;

        public void Set_Gold(int gold)
        {
            gold_Text.text = "골드(" + gold + ")";
        }

        public void Set_Cash(int cash)
        {
            cash_Text.text = "캐쉬(" + cash + ")";
        }
        #endregion
    }
}
