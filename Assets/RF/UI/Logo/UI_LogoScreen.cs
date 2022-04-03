using System;
using DG.Tweening;
using RF.UI.Base;
using RF.UI.Loading;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Logo
{
    public class UI_LogoScreen : MonoBehaviour, IUI_Base, IUI_Fade
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
            ui_Model = new UI_LogoScreen_Model();
            ui_Model.Initialize();

            ui_View.Logo_Fade(this, loadingScreen);
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

        public void Fade(Image ui, FadeType fadeType, float time, Action completeFunc)
        {
            switch (fadeType)
            {
                case FadeType.IN:
                    ui.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    ui.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }            
        }

        public void Fade(RawImage ui, FadeType fadeType, float time, Action completeFunc)
        {
            switch (fadeType)
            {
                case FadeType.IN:
                    ui.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    ui.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }             
        }

        public void Fade(TMP_Text ui, FadeType fadeType, float time, Action completeFunc)
        {
            switch (fadeType)
            {
                case FadeType.IN:
                    ui.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    ui.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }             
        }            
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_LogoScreen_View ui_View;
        [SerializeField]private UI_LogoScreen_Model ui_Model;
        #endregion
        
        #region 로딩 스크린
        [SerializeField] private UI_LoadingScreen loadingScreen;
        #endregion
    }
}
