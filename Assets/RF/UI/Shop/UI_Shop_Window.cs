using System;
using System.Collections.Generic;
using RF.Building;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Shop
{
    public class UI_Shop_Window : MonoBehaviour, IUI_Base
    {
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            Initialize();
            Setup();
        }

        private void Update()
        {
            Think();
        }
        #endregion
        
        #region 인터페이스
        public void Initialize()
        {
            Setup_Buildings();
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
        [SerializeField] private UI_Shop_Window_View ui_View;
        #endregion
        
        #region 상점
        [Title("상점")]
        [SerializeField] private GameObject ui_Item_Content;
        [SerializeField] private Transform content;
        #endregion
        
        #region 건물
        [Title("건물")] 
        [SerializeField] private List<BuildingData> buildingList;
        private void Setup_Buildings()
        {
            foreach (var data in buildingList)
            {
                GameObject obj = Instantiate(ui_Item_Content, content, false);
                
                UI_Item_ShopItem item = obj.GetComponent<UI_Item_ShopItem>();
                UI_Custom_Button btn = obj.GetComponent<UI_Custom_Button>();
                
                Sprite icon = Resources.Load<Sprite>(data.viewPrefabDir);

                item.GetView().Set_Icon(icon, data.cellSize.x);
                item.GetView().Set_Title(data.title);
                item.GetView().Set_Desc("골드 : " + data.gold + "\n캐쉬 : " + data.cash + "\n공간 :"  + data.cellSize + "\n\n설명 : " + data.desc);

                btn.onClick.AsObservable().Subscribe(unit =>
                {
                    ui_View.BuyPopup(data);
                });                
            }
        }
        #endregion
    }
}
