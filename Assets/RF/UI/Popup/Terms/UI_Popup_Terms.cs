using System;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace RF.UI.Terms
{
    public class UI_Popup_Terms : UI_Popup_Base
    {
        #region MVP 
        [Title("MVP")]
        public UI_Popup_Terms_Model ui_Model;
        public UI_Popup_Terms_View ui_View;         
        #endregion
        
        #region Popup 오버라이드 함수

        public override void Initialize()
        {
            Setup_Close();
            
            if (PlayerPrefs.HasKey("term_Toggle") && PlayerPrefs.GetInt("term_Toggle") == 1)
            {
                gameObject.SetActive(false);
            }
        }

        public override void Setup()
        {
            
        }
        
        public override void Think()
        {
           
        }        

        public override void OnRemove()
        {
            
        }

        public override void Remove()
        {
            
        }

        #endregion
        
        #region 약관
        [SerializeField] private Button close_Btn;
        [SerializeField] private Toggle term_Toggle;
        private void Setup_Close()
        {
            close_Btn.OnClickAsObservable().Subscribe(unit =>
            {
                PlayerPrefs.SetInt("term_Toggle", Convert.ToInt32(term_Toggle.isOn));
                
                gameObject.SetActive(false);
            });
        }
        #endregion
    }
}
