﻿using ModelModul.Product;

namespace ModelModul.Report
{
    public class FinalReportProductViewModel : ProductViewModel
    {
        private decimal _finalSum;
        public decimal FinalSum
        {
            get => _finalSum;
            set => SetProperty(ref _finalSum, value);
        }

        private double _count;
        public new double Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }
    }
}
