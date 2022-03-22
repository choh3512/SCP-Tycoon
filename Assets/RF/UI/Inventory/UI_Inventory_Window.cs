using System.Collections.Generic;
using RF.Building;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Inventory
{
    public class UI_Inventory_Window : UI_Base
    {
        #region UI 오버라이드 함수
        public override void Initialize()
        {
            foreach (var data in Main.Main.Instance.GameData.BuildingInv[buildingType])
            {
                ui_View.AddItem(data);
            }
        }
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Inventory_Window_View ui_View;
        #endregion
        
        #region 건물
        [Title("건물")] 
        [SerializeField] private BuildingType buildingType;
        #endregion
    }
}
