using RF.Building;
using RF.UI.Base;
using RF.UI.Popup.ShopBuy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Room
{
    public class UI_Shop_Room_View : UI_View_Base
    {
        #region 팝업 
        [Title("팝업")]
        [SerializeField] private UI_Popup_ShopBuy popup_ShopBuy;

        public void BuyPopup(BuildingData data)
        {
            popup_ShopBuy.SetTitle("구매");
            popup_ShopBuy.SetText(data.title + "을(를) 정말로 구매하시겠습니까?");

            popup_ShopBuy.Set_Data(data);          
            
            popup_ShopBuy.gameObject.SetActive(true);
        }
        #endregion
    }
}
