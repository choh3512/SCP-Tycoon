using RF.Building;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;

namespace RF.UI.Popup.ShopBuy
{
    public class UI_Popup_ShopBuy : UI_Popup_Base
    {
        #region UI 인터페이스 함수
        public override void Initialize()
        {
            ui_Model = new UI_Popup_ShopBuy_Model();
            ui_Model.Initialize();

            Setup_Btns();
        }

        public override void Setup()
        {
            Setup_Price();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Popup_ShopBuy_View ui_View;
        private UI_Popup_ShopBuy_Model ui_Model;
        #endregion
        
        #region 가격
        private void Setup_Price()
        {
            if (buildingData != null)
            {
                ui_View.Set_Gold(buildingData.gold);
                ui_View.Set_Cash(buildingData.cash);     
            }
        }
        #endregion
        
        #region 버튼
        [Title("버튼")] 
        [SerializeField] private UI_Custom_Button gold_Btn;
        [SerializeField] private UI_Custom_Button cash_Btn;
        [SerializeField] private UI_Custom_Button close_Btn;

        private void Setup_Btns()
        {
            gold_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);

                Buy(false);
            });
            
            cash_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);

                Buy(true);
            });
            
            close_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);

                buildingData = null;
            });
        }
        #endregion
        
        #region 구매
        private BuildingData buildingData;
        
        public void Set_Data(BuildingData data)
        {
            buildingData = data;
        }
        
        private void Buy(bool isCash)
        {
            if (buildingData == null)
            {
                gameObject.SetActive(false);
                return;
            }

            if (isCash)
            {
                if (Main.Main.Instance.GameData.Cash >= buildingData.cash)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                if (Main.Main.Instance.GameData.Money >= buildingData.gold)
                {
                    
                }
                else
                {
                    
                }                
            }

            buildingData = null;
        }
        #endregion
    }
}
