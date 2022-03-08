using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.Ingame
{
    public class Ingame : MonoBehaviour
    {
        #region 유니티 기본 내장 함수
        private void Awake()
        {
            
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }
        #endregion
        
        #region 플레이어
        [Title("플레이어")] 
        [SerializeField] private Player.Player player;

        public Player.Player GetPlayer()
        {
            return player;
        }
        #endregion
    }
}
