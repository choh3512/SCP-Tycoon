using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Base.Button
{
    public class UI_Custom_Button_View : MonoBehaviour
    {
        #region 버튼
        [SerializeField] private Image background;

        public void SetBGColor(Color color)
        {
            background.color = color;
        }
        #endregion
    }
}
