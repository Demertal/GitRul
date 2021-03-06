﻿using System.Collections.Generic;

namespace ModelModul.Models
{
    public class MovmentGoodType : ModelBase<MovmentGoodType>
    {
         public MovmentGoodType()
        {
            MovementGoodsCollection = new List<MovementGoods>();
        }

        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _code;
        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private ICollection<MovementGoods> _movementGoodsCollection;
        public virtual ICollection<MovementGoods> MovementGoodsCollection
        {
            get => _movementGoodsCollection;
            set
            {
                _movementGoodsCollection = value;
                OnPropertyChanged();
            }
        }

        public override bool IsValid => true;
    }
}
