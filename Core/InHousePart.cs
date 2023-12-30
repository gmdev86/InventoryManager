namespace InventoryManager.Core
{
    public class InHousePart : Part
    {
        #region Private Properties

        private int partId;

        #endregion

        #region Public Properties

        public int PartId
        {
            get { return partId; }
            set { partId = value; }
        }

        #endregion

        #region Constructors

        public InHousePart()
        {
        }

        public InHousePart(string name, double price, int inv, int min, int max, int partId)
            : base(name, price, inv, min, max)
        {
            this.partId = partId;
        }

        #endregion

        #region Public Methods

        public int GetPartId()
        {
            return partId;
        }

        public void SetPartId(int partId)
        {
            this.partId = partId;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"InHousePart{{Id={Id}, Name='{Name}', Price={Price}, Inv={Inv}, Min={Min}, Max={Max}, PartId={partId}}}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            InHousePart otherPart = (InHousePart)obj;

            return base.Equals(obj) && partId == otherPart.partId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), partId);
        }

        #endregion
    }
}
