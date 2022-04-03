using System;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;
using UniRx;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

namespace RF.UI
{
    public interface IUI_Base
    {
        public void Initialize();
        public void Setup();
        public void Think();
        public void Remove();
        public void OnRemove();
    }

    public interface IUI_Fade
    {
        public void Fade(Image ui, FadeType fadeType, float time, Action completeFunc);
        public void Fade(RawImage ui, FadeType fadeType, float time, Action completeFunc);
        public void Fade(TMP_Text ui, FadeType fadeType, float time, Action completeFunc);        
    }
    
    public class UI_Base : MonoBehaviour, IUI_Base, IUI_Fade
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
            OnRemove();
        }

        public void OnRemove()
        {
            
        }

        public void Hide(bool isHide)
        {
            gameObject.SetActive(!isHide);
        }

        public void Fade(Image image, FadeType fadeType, float time, Action completeFunc)
        {

            /*CustomDebug.DebugManager.Instance.Log(this, "UI : " + ui.GetType().BaseType);
            CustomDebug.DebugManager.Instance.Log(this, "Image : " + ui.GetType().Equals(typeof(Image)));
            CustomDebug.DebugManager.Instance.Log(this, "TMP : " + ui.GetType().Equals(typeof(TMP_Text)));
            CustomDebug.DebugManager.Instance.Log(this, "RawImage : " + ui.GetType().Equals(typeof(RawImage)));*/
            
            switch (fadeType)
            {
                case FadeType.IN:
                    image.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    image.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }
        }
        
        public void Fade(RawImage rawImage, FadeType fadeType, float time, Action completeFunc)
        {

            /*CustomDebug.DebugManager.Instance.Log(this, "UI : " + ui.GetType().BaseType);
            CustomDebug.DebugManager.Instance.Log(this, "Image : " + ui.GetType().Equals(typeof(Image)));
            CustomDebug.DebugManager.Instance.Log(this, "TMP : " + ui.GetType().Equals(typeof(TMP_Text)));
            CustomDebug.DebugManager.Instance.Log(this, "RawImage : " + ui.GetType().Equals(typeof(RawImage)));*/
            
            switch (fadeType)
            {
                case FadeType.IN:
                    rawImage.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    rawImage.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }
        }
        
        public void Fade(TMP_Text tmpText, FadeType fadeType, float time, Action completeFunc)
        {

            /*CustomDebug.DebugManager.Instance.Log(this, "UI : " + ui.GetType().BaseType);
            CustomDebug.DebugManager.Instance.Log(this, "Image : " + ui.GetType().Equals(typeof(Image)));
            CustomDebug.DebugManager.Instance.Log(this, "TMP : " + ui.GetType().Equals(typeof(TMP_Text)));
            CustomDebug.DebugManager.Instance.Log(this, "RawImage : " + ui.GetType().Equals(typeof(RawImage)));*/
            
            switch (fadeType)
            {
                case FadeType.IN:
                    tmpText.DOFade(1F, time).OnComplete(()=>completeFunc());
                    break;
                case  FadeType.OUT:
                    tmpText.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    break;
                case FadeType.NONE:
                    break;
            }
        }
        #endregion
        
        #region MVP

        #endregion
    }
}
