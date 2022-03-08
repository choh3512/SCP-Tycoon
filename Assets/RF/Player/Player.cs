using System;
using UnityEngine;

namespace RF.Player
{
    public class Player : MonoBehaviour
    {
        #region 유니티 기본 내장 함수
        private void Awake()
        {
            playerData.Initialize();
            playerController.Initialize();
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            playerController.Update();
        }

        #endregion
        
        #region 플레이어 데이터
        private PlayerData playerData = new PlayerData();

        public PlayerData GetPlayerData()
        {
            return playerData;
        }
        #endregion
        
        #region 플레이어 컨트롤러
        private IPlayerController playerController = new PlayerController();

        public IPlayerController GetPlayerController()
        {
            return playerController;
        }
        #endregion
    }
}
