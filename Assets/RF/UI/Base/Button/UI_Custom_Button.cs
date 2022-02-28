using System;
using RF.UI.Base.Button;
using UnityEngine;
using UnityEngine.EventSystems;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine.Events;

namespace RF.UI.Base
{
    public class UI_Custom_Button : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
    {
         
        #region MVP
        [Title("MVP")]
        public UI_Custom_Button_View ui_View;
        public UI_Custom_Button_Model ui_Model;
        #endregion

        #region 버튼 이벤트
        [Title("이벤트")]
        public UnityEvent onClick;
        public UnityEvent onRelease;
        public UnityEvent onCursorEntered;
        public UnityEvent onCursorExited;
        #endregion
        
        #region
        [Title("색상")] 
        [SerializeField] private Color normalColor;
        [SerializeField] private Color highlightColor;
        [SerializeField] private Color pressedColor;
        #endregion
        
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            ui_View.SetBGColor(normalColor);
            
            ui_Model = new UI_Custom_Button_Model();
            ui_Model.Initialize();
        }

        #endregion       

        #region 마우스 포인터 이벤트 
        public void OnPointerClick(PointerEventData eventData)
        {
            onClick.Invoke();
            
            ui_View.SetBGColor(pressedColor);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            onCursorEntered.Invoke();
            
            ui_View.SetBGColor(highlightColor);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            onCursorExited.Invoke();
            
            ui_View.SetBGColor(normalColor);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            onRelease.Invoke();
            
            ui_View.SetBGColor(normalColor);
        }
        #endregion
    }
}
