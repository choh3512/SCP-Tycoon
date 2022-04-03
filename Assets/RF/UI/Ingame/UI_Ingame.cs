using System;
using RF.UI.Base;
using RF.UI.Inventory;
using RF.UI.Shop;
using RF.UI.Top;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Ingame
{
    public class UI_Ingame : MonoBehaviour, IUI_Base
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
            ui_Model = new UI_Ingame_Model();
            ui_Model.Initialize();

            Setup_Buttons();
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
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Ingame_View ui_View;
        [SerializeField] private UI_Ingame_Model ui_Model;
        #endregion
        
        #region UI Ingame
        [Title("인게임 UI")]
        [SerializeField] private UI_Ingame_Top ui_Top;
        #endregion
        
        #region UI Shop
        [Title("상점 UI")] 
        [SerializeField] private UI_Shop ui_Shop;
        #endregion

        #region UI Inventory
        [Title("인벤토리 UI")] 
        [SerializeField] private UI_Inventory ui_Inventory;
        #endregion
        
        #region Buttons 
        [Title("버튼")]
        [SerializeField] private UI_Custom_Button shop_Btn;
        [SerializeField] private UI_Custom_Button build_Btn;

        private void Setup_Buttons()
        {
            shop_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);
                ui_Shop.gameObject.SetActive(true);
            });

            build_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);
                ui_Inventory.gameObject.SetActive(true);
            });
        }
        #endregion
        
        #region 인게임
        [Title("인게임")] 
        public RF.Ingame.Ingame ingame;
        #endregion
    }
}
