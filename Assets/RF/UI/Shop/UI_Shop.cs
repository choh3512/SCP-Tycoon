using RF.UI.Base;
using RF.UI.Ingame;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Shop
{
    public class UI_Shop : MonoBehaviour, IUI_Base
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
            Setup_Close();
            Setup_Cats();
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
        #endregion
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_Shop_View ui_View;
        private UI_Shop_Model ui_Model;

        public UI_Shop_View GetView()
        {
            return ui_View;
        }
        #endregion
        
        #region UI Ingame
        [Title("인게임 UI")] 
        [SerializeField] private UI_Ingame ui_Ingame;
        #endregion
        
        #region UI Shop
        [Title("카테고리")]
        [SerializeField] private UI_Custom_Button cat_Room_Btn;
        [SerializeField] private UI_Custom_Button cat_Training_Btn;
        [SerializeField] private UI_Custom_Button cat_Generator_Btn;
        [SerializeField] private UI_Custom_Button cat_Research_Btn;
        [SerializeField] private UI_Custom_Button cat_Movement_Btn;
        [SerializeField] private UI_Custom_Button cat_Misc_Btn;
        private void Setup_Cats()
        {
            cat_Room_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(true);
                ui_View.Show_Generator(false);
                ui_View.Show_Misc(false);
                ui_View.Show_Movement(false);
                ui_View.Show_Research(false);
                ui_View.Show_Training(false);
            });
            
            cat_Training_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(false);
                ui_View.Show_Generator(false);
                ui_View.Show_Misc(false);
                ui_View.Show_Movement(false);
                ui_View.Show_Research(false);
                ui_View.Show_Training(true);
            });
            
            cat_Generator_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(false);
                ui_View.Show_Generator(true);
                ui_View.Show_Misc(false);
                ui_View.Show_Movement(false);
                ui_View.Show_Research(false);
                ui_View.Show_Training(false);
            });
            
            cat_Research_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(false);
                ui_View.Show_Generator(false);
                ui_View.Show_Misc(false);
                ui_View.Show_Movement(false);
                ui_View.Show_Research(true);
                ui_View.Show_Training(false);
            });
            
            cat_Movement_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(false);
                ui_View.Show_Generator(false);
                ui_View.Show_Misc(false);
                ui_View.Show_Movement(true);
                ui_View.Show_Research(false);
                ui_View.Show_Training(false);
            });
            
            cat_Misc_Btn.onSelected.AsObservable().Subscribe(unit =>
            {
                ui_View.Show_Rooms(false);
                ui_View.Show_Generator(false);
                ui_View.Show_Misc(true);
                ui_View.Show_Movement(false);
                ui_View.Show_Research(false);
                ui_View.Show_Training(false);
            });
        }
        #endregion
        
        #region 닫기
        [Title("닫기")] 
        [SerializeField] private UI_Custom_Button close_Btn;

        private void Setup_Close()
        {
            close_Btn.onClick.AsObservable().Subscribe(unit =>
            {
                gameObject.SetActive(false);
                ui_Ingame.gameObject.SetActive(true);
            });
        }
        #endregion
    }
}
