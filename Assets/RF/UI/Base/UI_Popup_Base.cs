using System;
using Sirenix.OdinInspector;
using TMPro;
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
        public void SetTitle(string text);
        public void SetText(string text);
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
        }

        private void Update()
        {
            Think();
        }

        private void OnDestroy()
        {
            OnRemove();
        }

        private void OnEnable()
        {
            Setup();
        }

        #endregion

        #region 텍스트 설정
        [Title("팝업 텍스트")]
        [SerializeField] private TMP_Text title_Text;
        [SerializeField] private TMP_Text main_Text;
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

        public void SetTitle(string text)
        {
            title_Text.text = text;
            
            Debug.Log(title_Text.text);
        }

        public void SetText(string text)
        {
            main_Text.text = text;
            
            Debug.Log(main_Text.text);
        }
        #endregion
    }
}
