namespace InventoryManager.Core
{
    public class OutsourcedPart : Part
    {
        #region Private Properties

        private string companyName;

        #endregion

        #region Public Properties

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        #endregion

        #region Constructors

        public OutsourcedPart()
        {
        }

        public OutsourcedPart(string name, double price, int inv, int min, int max, string companyName)
            : base(name, price, inv, min, max)
        {
            this.companyName = companyName;
        }

        #endregion

        #region Public Methods

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"OutsourcedPart{{Id={Id}, Name='{Name}', Price={Price}, Inv={Inv}, Min={Min}, Max={Max}, CompanyName='{companyName}'}}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            OutsourcedPart otherPart = (OutsourcedPart)obj;

            return base.Equals(obj) && companyName == otherPart.companyName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), companyName);
        }

        #endregion
    }
}
