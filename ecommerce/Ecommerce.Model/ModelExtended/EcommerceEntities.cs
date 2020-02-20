namespace Ecommerce.Model.ModelExtended
{
    public partial class EcommerceEntities
    {
        #region PROPS

        private string _userName;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        private User _user;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        #endregion
    }
}
