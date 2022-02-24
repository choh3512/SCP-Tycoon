namespace RF.Exploration
{
    public class ExploreData
    {
        #region 탐사 체크
        private bool _isExplored = false;
        public bool IsExplored
        {
            get { return _isExplored; }
            set { _isExplored = value; }
        }
        #endregion
        
        #region 탐사 성공 여부
        private bool _isComplete = false;
        public bool IsComplete
        {
            get { return _isComplete; }
            set { _isComplete = value; }
        }
        #endregion
        
        #region 탐사 점수
        private int _score = 0;
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        #endregion
    }
}
