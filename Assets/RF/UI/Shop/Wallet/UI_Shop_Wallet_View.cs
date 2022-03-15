using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace RF.UI.Shop.Wallet
{
    public class UI_Shop_Wallet_View : UI_View_Base
    {
        #region 지갑 
        [Title("지갑")] 
        [SerializeField] private TMP_Text gold_Text;
        [SerializeField] private TMP_Text cash_Text;

        public void Set_Gold(int gold)
        {
            gold_Text.text = gold.ToString();
        }

        public void Set_Cash(int cash)
        {
            cash_Text.text = cash.ToString();
        }
        #endregion
    }
}
