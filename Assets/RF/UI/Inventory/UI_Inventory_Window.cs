using System.Collections.Generic;
using RF.Building;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Inventory
{
    public class UI_Inventory_Window : MonoBehaviour, IUI_Base
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
        
        #region UI 오버라이드 함수
        public void Initialize()
        {
            foreach (var data in Main.Main.Instance.GameData.BuildingInv[buildingType])
            {
                ui_View.AddItem(data);
            }
        }

        public void Setup()
        {
            
        }

        public void Think()
        {
            
        }

        public void Remove()
        {
            OnRemove();
        }

        public void OnRemove()
        {
            
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
