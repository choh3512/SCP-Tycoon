using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Wallet
{
    public class UI_Shop_Wallet : MonoBehaviour, IUI_Base
    {
        #region UI 오버라이드 함수
        public void Initialize()
        {
            ui_Model = new UI_Shop_Wallet_Model();
            ui_Model.Initialize();

            Setup_Wallet();
        }

        public void Setup()
        {
            
        }

        public void Think()
        {
            
        }

        public void Remove()
        {
            
        }

        public void OnRemove()
        {
            
        }
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_Shop_Wallet_View ui_View;
        private UI_Shop_Wallet_Model ui_Model;
        #endregion
        
        #region 지갑

        private void Setup_Wallet()
        {
            ui_View.Set_Gold(Main.Main.Instance.GameData.Money);
            ui_View.Set_Cash(Main.Main.Instance.GameData.Cash);
        }
        #endregion
    }
}
