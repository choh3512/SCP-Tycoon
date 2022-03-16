using System;
using System.Collections.Generic;
using RF.UI.Base.Button;
using UnityEngine;
using UnityEngine.EventSystems;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine.Events;
using UnityEngine.UI;

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
        public UnityEvent onSelected;
        #endregion
        
        #region 버튼 기능
        [Title("기능 활성화/비활성화")] 
        [SerializeField] private bool isUseSelect = false;
        [SerializeField] private bool isUseSelect_Image = false;
        #endregion
        
        #region 버튼 선택
        [Title("선택")] 
        [SerializeField] private List<UI_Custom_Button> buttons = new List<UI_Custom_Button>();
        [SerializeField] private Image selectedImage; 
        private bool isSelected = false;
        #endregion
        
        #region 버튼 색상
        [Title("색상")] 
        [SerializeField] private Color normalColor;
        [SerializeField] private Color highlightColor;
        [SerializeField] private Color pressedColor;
        [SerializeField] private Color selectedColor;
        #endregion
        
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            ui_View.SetBGColor(normalColor);
            
            ui_Model = new UI_Custom_Button_Model();
            ui_Model.Initialize();
        }

        private void OnEnable()
        {
            ui_View.SetBGColor(normalColor);
        }
        #endregion       

        #region 마우스 포인터 이벤트 
        public void OnPointerClick(PointerEventData eventData)
        {
            onClick.Invoke();

            if (isUseSelect)
            {
                if (!isSelected)
                {
                    Select(true);

                    foreach (var btn in buttons)
                    {
                        if (btn == this)
                        {
                            continue;
                        }
                        btn.Select(false);
                    }
                }
                else
                {
                    Select(false);
                    ui_View.SetBGColor(pressedColor);
                }
            }
            else
            {
                ui_View.SetBGColor(pressedColor);
            }
            
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

            if (!isUseSelect)
            {
                ui_View.SetBGColor(normalColor);  
            }
            else
            {
                if (isSelected)
                {
                    ui_View.SetBGColor(selectedColor);   
                }
                else
                {
                    ui_View.SetBGColor(normalColor); 
                }
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            onRelease.Invoke();
            
            ui_View.SetBGColor(normalColor);
        }
        #endregion
        
        #region 버튼 선택
        public void Select(bool boolean)
        {
            isSelected = boolean;

            switch (isSelected)
            {
                case true:
                {
                    onSelected.Invoke();
                    
                    ui_View.SetBGColor(selectedColor);

                    if (isUseSelect_Image)
                    {
                        selectedImage.gameObject.SetActive(true);
                    }
                }
                    break;
                case false:
                {
                    ui_View.SetBGColor(normalColor);
                    
                    if (isUseSelect_Image)
                    {
                        selectedImage.gameObject.SetActive(false);
                    }
                }
                    break;
            }
        }
        #endregion
    }
}
