namespace ModelModul.Models
{
    public class PriceProduct : ModelBase<PriceProduct>
    {
        private long _id;
        public long Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private long _idProduct;
        public long IdProduct
        {
            get => _idProduct;
            set
            {
                _idProduct = value;
                OnPropertyChanged();
            }
        }

        private long _idRevaluation;
        public long IdRevaluation
        {
            get => _idRevaluation;
            set
            {
                _idRevaluation = value;
                OnPropertyChanged();
            }
        }

        private decimal _price;
        public virtual decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsValid));
            }
        }

        private Product _product;
        public virtual Product Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged();
            }
        }

        private RevaluationProduct _revaluationProduct;
        public virtual RevaluationProduct RevaluationProduct
        {
            get => _revaluationProduct;
            set
            {
                _revaluationProduct = value;
                OnPropertyChanged();
            }
        }

        public override string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "Price":
                        if (Price <= 0)
                        {
                            error = "���� �� ����� ���� ������ ��� ������ 0";
                        }
                        break;
                }
                return error;
            }
        }

        public override object Clone()
        {
            return new PriceProduct{Id = Id, IdProduct = IdProduct, IdRevaluation = IdRevaluation, Price = Price};
        }

        public override bool IsValid => Price > 0 && !HasErrors;
    }
}