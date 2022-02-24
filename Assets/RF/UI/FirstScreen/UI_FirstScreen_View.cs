using System;
using System.Collections;
using DG.Tweening;
using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RF.UI.FirstScreen
{
    public class UI_FirstScreen_View : UI_View_Base
    {
        #region 로고
        [Title("로고")]
        [SerializeField] private Image logo_background;
        
        [SerializeField]private TMP_Text logo_title_Text;
        [SerializeField]private TMP_Text logo_copyright_Text;

        public void SetTitle(string text)
        {
            logo_title_Text.text = text;
        }

        public void SetTitle_Alpha(float alpha)
        {
            logo_title_Text.DOColor(new Color(logo_title_Text.color.r, logo_title_Text.color.g, logo_title_Text.color.b, alpha), 1F).onComplete = () =>
            {
                if (logo_background.gameObject.activeSelf)
                {
                    logo_background.gameObject.SetActive(false);
                }
                
                StartCoroutine("StartLoading");
            };
        }

        public float GetTitle_Alpha()
        {
            return logo_title_Text.alpha;
        }

        public void SetCopyright(string text)
        {
            logo_copyright_Text.text = text;
        }

        public void SetCopyright_Alpha(float alpha)
        {
            logo_copyright_Text.DOColor(new Color(logo_copyright_Text.color.r, logo_copyright_Text.color.g, logo_copyright_Text.color.b, alpha), 1F).onComplete = ()=>
            {
                if (logo_background.gameObject.activeSelf)
                {
                    logo_background.gameObject.SetActive(false);
                }                 
            };
        }

        public float GetCopyright_Alpha()
        {
            return logo_copyright_Text.alpha;
        }
        #endregion
        
        #region 로딩
        [Title("로딩")]
        [SerializeField] private Image loading_background;
        
        [SerializeField] private TMP_Text loading_title_Text;
        [SerializeField] private TMP_Text loading_tip_Text;

        [SerializeField] private Slider loading_slider;

        public void SetLoading_Title(string text)
        {
            loading_title_Text.text = text;
        }

        public void SetLoading_Title_Alpha(float alpha)
        {
            loading_title_Text.DOColor
            (new Color(loading_title_Text.color.r, loading_title_Text.color.g, loading_title_Text.color.b, alpha), 1F);
        }

        public void SetLoading_Tip(string text)
        {
            loading_tip_Text.text = text;
        }

        public void SetLoading_Tip_Alpha(float alpha)
        {
            loading_tip_Text.DOColor
                (new Color(loading_tip_Text.color.r, loading_tip_Text.color.g, loading_tip_Text.color.b, alpha), 1F);
        }

        public bool GetLoading_Tip_Active()
        {
            return loading_tip_Text.gameObject.activeSelf;
        }

        IEnumerator StartLoading()
        {
            loading_background.gameObject.SetActive(true);
                
            SetLoading_Title_Alpha(1F);
            SetLoading_Tip_Alpha(1F);            
            
            var ao = SceneManager.LoadSceneAsync("Game");
            ao.allowSceneActivation = false;
            
            float timer = 0F;

            while (!ao.isDone)
            {
                yield return null;
                /*timer += Time.deltaTime;
                if (ao.progress < 0.9F)
                {
                    loading_slider.value = Mathf.Lerp(loading_slider.value, ao.progress, timer);
                    if (loading_slider.value >= ao.progress)
                    {
                        timer = 0F;
                    }
                }
                else
                {
                    loading_slider.value = Mathf.Lerp(loading_slider.value, 1F, timer);

                    if (loading_slider.value >= 1F)
                    {
                        ao.allowSceneActivation = true;

                        yield break;
                    }
                }*/

            }
        }
        #endregion
    }
}
