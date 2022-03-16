using System.Collections.Generic;
using RF.Building;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;

namespace RF.UI.Shop.Room
{
    public class UI_Shop_Room : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Room_Model();
            ui_Model.Initialize();

            Setup_Items();
        }
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_Shop_Room_View ui_View;
        private UI_Shop_Room_Model ui_Model;
        #endregion
        
        #region 아이템
        [Title("아이템")] 
        [SerializeField] private List<BuildingData> roomList;
       
        [SerializeField] private Transform content;
        [SerializeField] private GameObject ui_Item_Content;
        
        private void Setup_Items()
        {
            foreach (var room in roomList)
            {
                GameObject obj = Instantiate(ui_Item_Content, content, false);
                
                UI_Item_ShopItem item = obj.GetComponent<UI_Item_ShopItem>();
                UI_Custom_Button btn = obj.GetComponent<UI_Custom_Button>();
                
                Sprite icon = Resources.Load<Sprite>(room.viewPrefabDir);

                item.GetView().Set_Icon(icon);
                item.GetView().Set_Title(room.title);
                item.GetView().Set_Desc("골드 : " + room.gold + "\n캐쉬 : " + room.cash + "\n공간 :"  + room.cellSize + "\n\n설명 : " + room.desc);

                btn.onClick.AsObservable().Subscribe(unit =>
                {
                    ui_View.BuyPopup(room);
                });
            }
        }
        #endregion
    }
}
