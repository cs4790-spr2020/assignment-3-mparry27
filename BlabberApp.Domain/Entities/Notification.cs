using BlabberApp.Domain.Interfaces;

namespace BlabberApp.Domain.Entities
{
    public class Notification : BaseDatum
    {
        private string _blab;
        public string Blab
        {
            get { return this._blab; }
            set { this._blab = value; }
        }
        private string _userId;
        public string UserID
        {
            get { return this._userId; }
            set { this._userId = value; }
        }
    }
}