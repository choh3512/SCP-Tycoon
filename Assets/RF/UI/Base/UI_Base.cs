using System;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;
using UniRx;

namespace RF.UI
{
    public interface IUI_Base
    {
        public void Initialize();
        public void Setup();
        public void Think();
        public void Remove();
        public void OnRemove();
        public void Hide(bool isHide);
    }
    
    public class UI_Base : MonoBehaviour, IUI_Base
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

        public virtual void Remove()
        {
            
        }

        public virtual void OnRemove()
        {
            
        }

        public virtual void Hide(bool isHide)
        {
            gameObject.SetActive(!isHide);
        }
        #endregion
        
        #region MVP

        #endregion
    }
}
