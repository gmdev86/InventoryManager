namespace InventoryManager.Core
{
    public abstract class Part
    {
        #region Private Properties

        private long id;
        private string name;
        private double price;
        private int inv;
        private int min;
        private int max;
        private HashSet<Product> products;

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

        public HashSet<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        #endregion

        #region Constructors

        protected Part()
        {
        }

        protected Part(string name, double price, int inv, int min, int max)
        {
            this.name = name;
            this.price = price;
            this.inv = inv;
            this.min = min;
            this.max = max;
            products = new HashSet<Product>();
        }

        protected Part(long id, string name, double price, int inv, int min, int max)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.inv = inv;
            this.min = min;
            this.max = max;
            products = new HashSet<Product>();
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"Part{{id={id}, name='{name}', price={price}, inv={inv}, min={min}, max={max}, products={products}}}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Part otherPart = (Part)obj;

            return id == otherPart.id &&
                   name == otherPart.name &&
                   price == otherPart.price &&
                   inv == otherPart.inv &&
                   min == otherPart.min &&
                   max == otherPart.max;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, price, inv, min, max, products);
        }

        #endregion
    }
}
