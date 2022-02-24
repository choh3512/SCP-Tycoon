using System;
using UnityEngine;

namespace RF.UI.Base
{
    public interface IUI_Popup_Base
    {
        public void Initialize();
        public void Setup();
        public void Think();
        public void OnRemove();
        public void Remove();
    }
    
    public class UI_Popup_Base : MonoBehaviour,IUI_Popup_Base
    {
        #region 유니티 기본 내장 함수
        private void Awake()
        {
            
        }

        private void Start()
        {
            Initialize();
            Setup();
        }

        private void Update()
        {
            Think();
        }

        private void OnDestroy()
        {
            OnRemove();
        }
        #endregion

        #region UI 인터페이스 함수 
        public virtual void Initialize()
        {
            
        }

        public virtual void Setup()
        {
           
        }

        public virtual void Think()
        {
          
        }

        public virtual void OnRemove()
        {
          
        }

        public virtual void Remove()
        {
            
        }
        #endregion
    }
}
