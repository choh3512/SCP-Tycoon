using System;
using UnityEngine;

namespace RF.UI.Inventory
{
    public class UI_Item_Inventory : MonoBehaviour, IUI_Base
    {
        #region 유니티 기본 내장

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
        
        #endregion
    }
}
