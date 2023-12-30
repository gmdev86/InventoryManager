namespace InventoryManager.Core
{
    public class Product
    {
        #region Private Properties

        private long id;
        private string name;
        private double price;
        private int inv;
        private int min;
        private int max;
        private List<ProductPart> parts { get; set; } = new List<ProductPart>();

        #endregion

        #region Public Properties

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Inv
        {
            get { return inv; }
            set { inv = value; }
        }

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public List<ProductPart> Parts
        {
            get { return parts; }
            set { parts = value; }
        }

        #endregion

        #region Constructors

        public Product()
        {
            parts = new List<ProductPart>();
        }

        public Product(string name, double price, int inv, int min, int max)
        {
            this.name = name;
            this.price = price;
            this.inv = inv;
            this.min = min;
            this.max = max;
            parts = new List<ProductPart>();
        }

        public Product(long id, string name, double price, int inv, int min, int max)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.inv = inv;
            this.min = min;
            this.max = max;
            parts = new List<ProductPart>();
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"Product{{Id={id}, Name='{name}', Price={price}, Inv={inv}, Min={min}, Max={max}, Parts={parts}}}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product otherProduct = (Product)obj;

            return id == otherProduct.id &&
                   name == otherProduct.name &&
                   price == otherProduct.price &&
                   inv == otherProduct.inv &&
                   min == otherProduct.min &&
                   max == otherProduct.max;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, price, inv, min, max);
        }

        #endregion
    }
}
