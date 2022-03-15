using System.Collections.Generic;
using RF.Building;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop.Generator
{
    public class UI_Shop_Generator : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            ui_Model = new UI_Shop_Generator_Model();
            ui_Model.Initialize();

            Setup_Items();
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Shop_Generator_View ui_View;
        private UI_Shop_Generator_Model ui_Model;
        #endregion
        
        #region 아이템
        [Title("아이템")] 
        [SerializeField] private List<BuildingData> generatorList;
       
        [SerializeField] private Transform content;
        [SerializeField] private GameObject ui_Item_Content;
        
        private void Setup_Items()
        {
            foreach (var generator in generatorList)
            {
                GameObject obj = Instantiate(ui_Item_Content, content, false);
                UI_Item_ShopItem item = obj.GetComponent<UI_Item_ShopItem>();
                
                Sprite icon = Resources.Load<Sprite>(generator.viewPrefabDir);
                
                Debug.Log(generator.viewPrefabDir);
                Debug.Log(icon);
                
                item.GetView().Set_Icon(icon);
                item.GetView().Set_Title(generator.title);
                item.GetView().Set_Desc(generator.desc);
            }
        }
        #endregion
    }
}
