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
        public void Hide(bool isHide);
        public void Fade<T>(T ui, FadeType fadeType, float time, Action completeFunc);
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

        public virtual void Fade<T>(T ui, FadeType fadeType, float time, Action completeFunc)
        {
            Type type = ui as Type;
            
            Image image = null;
            TMP_Text tmpText = null;
            RawImage rawImage = null;

            switch (ui.GetType().BaseType.Equals(typeof(Image)))
            {
                case true:
                    image = ui as Image;
                    break;
            }
            
            switch (ui.GetType().BaseType.Equals(typeof(TMP_Text)))
            {
                case true:
                    tmpText = ui as TMP_Text;
                    break;
            }
            
            switch (ui.GetType().BaseType.Equals(typeof(RawImage)))
            {
                case true:
                    rawImage = ui as RawImage;
                    break;
            }
            
            CustomDebug.DebugManager.Instance.Log(this, "UI : " + ui.GetType().BaseType);
            CustomDebug.DebugManager.Instance.Log(this, "Image : " + ui.GetType().Equals(typeof(Image)));
            CustomDebug.DebugManager.Instance.Log(this, "TMP : " + ui.GetType().Equals(typeof(TMP_Text)));
            CustomDebug.DebugManager.Instance.Log(this, "RawImage : " + ui.GetType().Equals(typeof(RawImage)));
            
            switch (fadeType)
            {
                case FadeType.IN:
                    if (image != null)
                    {
                        image.DOFade(1F, time).OnComplete(()=>completeFunc());
                    }

                    if (tmpText != null)
                    {
                        tmpText.DOFade(1F, time).OnComplete(()=>completeFunc());
                    }

                    if (rawImage != null)
                    {
                        rawImage.DOFade(1F, time).OnComplete(()=>completeFunc());;
                    }
                    break;
                case  FadeType.OUT:
                    if (image != null)
                    {
                        image.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    }

                    if (tmpText != null)
                    {
                        tmpText.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    }

                    if (rawImage != null)
                    {
                        rawImage.DOFade(0F, time).OnComplete(()=>completeFunc());;
                    }                    
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
