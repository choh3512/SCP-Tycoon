using System;
using System.Collections;
using RF.UI.Base;
using RF.UI.FirstScreen;
using RF.UI.Loading;
using RF.UI.Logo;
using Sirenix.OdinInspector;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RF.UI
{
    public class UI_FirstScreen : MonoBehaviour, IUI_Base
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
        
        #region MVP
        [Title("MVP")]
        [SerializeField]private UI_FirstScreen_Model ui_Model;
        [SerializeField]private UI_FirstScreen_View ui_View;      
        #endregion

        #region 인터페이스
        public void Initialize()
        {
            ui_Model = new UI_FirstScreen_Model();
            ui_Model.Initialize();
            //CustomDebug.DebugManager.Instance.Log(this, "Initialize");
            
            logoScreen.gameObject.SetActive(true);
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

        public void Fade(Image ui, FadeType fadeType, float time, Action completeFunc)
        {
            
        }

        public void Fade(RawImage ui, FadeType fadeType, float time, Action completeFunc)
        {
            
        }

        public void Fade(TMP_Text ui, FadeType fadeType, float time, Action completeFunc)
        {
           
        }        
        #endregion        
        
        #region 로고 
        [SerializeField]private UI_LogoScreen logoScreen;
        #endregion
        
        #region 로딩 
        [SerializeField]private UI_LoadingScreen loadingScreen;
        #endregion
    }
}
