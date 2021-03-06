namespace ModelModul.Models
{
    public class PropertyProduct : ModelBase<PropertyProduct>
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

        private int _idPropertyName;
        public int IdPropertyName
        {
            get => _idPropertyName;
            set
            {
                _idPropertyName = value;
                OnPropertyChanged();
            }
        }

        private int? _idPropertyValue;
        public int? IdPropertyValue
        {
            get => _idPropertyValue;
            set
            {
                _idPropertyValue = value;
                OnPropertyChanged();
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

        private PropertyName _propertyName;
        public virtual PropertyName PropertyName
        {
            get => _propertyName;
            set
            {
                _propertyName = value;
                OnPropertyChanged();
            }
        }

        private PropertyValue _propertyValue;
        public virtual PropertyValue PropertyValue
        {
            get => _propertyValue;
            set
            {
                _propertyValue = value;
                OnPropertyChanged();
            }
        }

        public override object Clone()
        {
            return new PropertyProduct
            {
                Id = Id,
                IdProduct = IdProduct,
                IdPropertyName = IdPropertyName,
                IdPropertyValue = IdPropertyValue
            };
        } 

        public override bool IsValid => true;
    }
}
