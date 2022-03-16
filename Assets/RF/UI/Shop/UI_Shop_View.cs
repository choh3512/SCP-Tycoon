using RF.UI.Base;
using RF.UI.Popup.ShopBuy;
using RF.UI.Shop.Generator;
using RF.UI.Shop.Misc;
using RF.UI.Shop.Movement;
using RF.UI.Shop.Research;
using RF.UI.Shop.Room;
using RF.UI.Shop.Training;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop
{
    public class UI_Shop_View : UI_View_Base
    {
        #region 격리 룸
        [Title("격리 룸")] 
        [SerializeField] private UI_Shop_Room ui_ShopRoom;

        public void Show_Rooms(bool isActive)
        {
            ui_ShopRoom.gameObject.SetActive(isActive);
        }
        #endregion
        
        #region 훈련 시설
        [Title("훈련 시설")]
        [SerializeField] private UI_Shop_Training ui_ShopTraining;

        public void Show_Training(bool isActive)
        {
            ui_ShopTraining.gameObject.SetActive(isActive);
        }
        #endregion
        
        #region 생산 시설
        [Title("생산 시설")] 
        [SerializeField] private UI_Shop_Generator ui_ShopGenerator;

        public void Show_Generator(bool isActive)
        {
            ui_ShopGenerator.gameObject.SetActive(isActive);
        }
        #endregion
        
        #region 연구 시설
        [Title("연구 시설")] 
        [SerializeField] 
        private UI_Shop_Research ui_ShopResearch;

        public void Show_Research(bool isActive)
        {
            ui_ShopResearch.gameObject.SetActive(isActive);
        }
        #endregion
        
        #region 이동 시설
        [Title("이동 시설")]
        [SerializeField] private UI_Shop_Movement ui_ShopMovement;

        public void Show_Movement(bool isActive)
        {
            ui_ShopMovement.gameObject.SetActive(isActive);
        }
        #endregion
        
        #region 기타
        [Title("기타")] 
        [SerializeField] private UI_Shop_Misc ui_ShopMisc;

        public void Show_Misc(bool isActive)
        {
            ui_ShopMisc.gameObject.SetActive(isActive);
        }
        #endregion
    }
}
