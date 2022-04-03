using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Top
{
    public class UI_Ingame_Top : MonoBehaviour, IUI_Base
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
            ui_Model = new UI_Ingame_Top_Model();
            ui_Model.Initialize();
        }

        public void Setup()
        {
            
        }

        public void Think()
        {
            
        }

        public void Remove()
        {
            Destroy(gameObject);
            
            OnRemove();
        }

        public void OnRemove()
        {
            
        }

        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Ingame_Top_View ui_View;
        [SerializeField] private UI_Ingame_Top_Model ui_Model;
        #endregion
    }
}
