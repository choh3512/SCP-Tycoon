using System;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Shop
{
    public class UI_Item_ShopItem : MonoBehaviour, IUI_Base
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
        [SerializeField] private UI_Item_ShopItem_View ui_View;

        public UI_Item_ShopItem_View GetView()
        {
            return ui_View;
        }
        #endregion


    }
}
