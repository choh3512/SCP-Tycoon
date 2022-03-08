using System.Collections;
using RF.UI.Base;
using Sirenix.OdinInspector;
using UnityEngine;
using UniRx;
using UnityEngine.SceneManagement;

namespace RF.UI.Loading
{
    public class UI_LoadingScreen : UI_Base
    {
        
        #region MVP
        [Title("MVP")] 
        [SerializeField] private UI_LoadingScreen_View ui_View;
        [SerializeField] private UI_LoadingScreen_Model ui_Model;
        #endregion        
        
        #region UI 오버라이드
        public override void Initialize()
        {
            base.Initialize();

            ui_Model = new UI_LoadingScreen_Model();
            ui_Model.Initialize();
            
            ui_Model.progress.ObserveEveryValueChanged(prop => prop.Value).Subscribe(value =>
            {
                ui_View.SetProgress(value);
            });
            
            StartCoroutine("Loading");
            StartCoroutine("Tip_Change");
        }
        #endregion
        
        #region 로딩

        [Title("로딩")] 
        [SerializeField] private string sceneName = "";
        
        IEnumerator Loading()
        {
            ui_View.gameObject.SetActive(true);

            var ao = SceneManager.LoadSceneAsync(sceneName);
            ao.allowSceneActivation = false;
            
            float timer = 0F;
            
            yield return null;

            while (!ao.isDone)
            {
                yield return null;
                timer += Time.deltaTime;
                if (ao.progress < 0.9F)
                {
                    ui_Model.progress.Value = Mathf.Lerp(ui_Model.progress.Value, ao.progress, timer);
                    if (ui_Model.progress.Value >= ao.progress)
                    {
                        timer = 0F;
                    }
                }
                else
                {
                    ui_Model.progress.Value = Mathf.Lerp(ui_Model.progress.Value, 1F, timer);

                    if (ui_Model.progress.Value >= 1F)
                    {
                        ao.allowSceneActivation = true;

                        yield break;
                    }
                }
            }
        }  
        
        private int tip_Index = 0;
        IEnumerator Tip_Change()
        {
            while (true)
            {
                if (tip_Index >= ui_Model.tip_Texts.Count) 
                { 
                    tip_Index = 0;
                }


                ui_View.Tip_Fade_OUT(this, ()=>{});
                    
                yield return new WaitForSeconds(3F);
                    
                ui_View.Tip_Fade_IN(this, ()=>{});
                    
                ui_View.SetTipText("팁 : " + ui_Model.tip_Texts["tip_" + (tip_Index+1)]);

                tip_Index++;
                yield return new WaitForSeconds(5F);
            }
        }   
        #endregion
    }
}
