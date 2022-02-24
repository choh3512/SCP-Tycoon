namespace RF.CustomDebug
{
    public static class DebugData 
    {
        #region 메인 시스템 디버그
        private static bool _isDebugMain = true;

        public static bool IsDebugMain
        {
            get { return _isDebugMain; }
        }
        #endregion
        
        #region 디버그 매니저 디버그

        private static bool _isDebugDebugManager = true;

        public static bool IsDebugDebugManager
        {
            get { return _isDebugDebugManager; }
        }

        #endregion
    }
}
