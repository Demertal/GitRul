﻿using Microsoft.EntityFrameworkCore;
using ModelModul.Models;
using ModelModul.Specifications.BasisSpecifications;

namespace ModelModul.Specifications
{
    public static class ProductSpecification
    {
        public static ExpressionSpecification<Product> GetProductsByBarcode(string barcode)
        {
            return new ExpressionSpecification<Product>(obj => obj.Barcode == barcode);
        }

        public static ExpressionSpecification<Product> GetProductsByLikeBarcode(string barcode)
        {
            barcode = "%" + barcode + "%";
            return new ExpressionSpecification<Product>(obj => EF.Functions.Like(obj.Barcode, barcode));
        }

        public static ExpressionSpecification<Product> GetProductsByLikeTitle(string title)
        {
            title = "%" + title + "%";
            return new ExpressionSpecification<Product>(obj => EF.Functions.Like(obj.Title, title));
        }

        public static ExpressionSpecification<Product> GetProductsByContainsVendorCode(string vendorCode)
        {
            vendorCode = "%" + vendorCode + "%";
            return new ExpressionSpecification<Product>(obj => EF.Functions.Like(obj.VendorCode, vendorCode));
        }

        public static ExpressionSpecification<Product> GetProductsByFindString(string findString)
        {
            return new ExpressionSpecification<Product>(GetProductsByLikeBarcode(findString)
                .Or(GetProductsByContainsVendorCode(findString).Or(GetProductsByLikeTitle(findString)))
                .IsSatisfiedBy());
        }

        public static ExpressionSpecification<Product> GetProductsByIdGroup(int idGroup)
        {
            return new ExpressionSpecification<Product>(obj => obj.IdCategory == idGroup);
        }

        public static ExpressionSpecification<Product> GetProductsByIdGroupOrFindString(int? idGroup, string findString)
        {
            return idGroup == null || idGroup == 0
                ? new ExpressionSpecification<Product>(GetProductsByFindString(findString).IsSatisfiedBy())
                : new ExpressionSpecification<Product>(GetProductsByIdGroup(idGroup.Value)
                    .And(GetProductsByFindString(findString)).IsSatisfiedBy());
        }
    }

    public static class ProductWithCountAndPriceSpecification
    {
        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByBarcode(string barcode)
        {
            return new ExpressionSpecification<ProductWithCountAndPrice>(obj => obj.Barcode == barcode);
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByLikeBarcode(string barcode)
        {
            barcode = "%" + barcode + "%";
            return new ExpressionSpecification<ProductWithCountAndPrice>(obj => EF.Functions.Like(obj.Barcode, barcode));
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByLikeTitle(string title)
        {
            title = "%" + title + "%";
            return new ExpressionSpecification<ProductWithCountAndPrice>(obj => EF.Functions.Like(obj.Title, title));
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByContainsVendorCode(string vendorCode)
        {
            vendorCode = "%" + vendorCode + "%";
            return new ExpressionSpecification<ProductWithCountAndPrice>(obj => EF.Functions.Like(obj.VendorCode, vendorCode));
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByFindString(string findString)
        {
            return new ExpressionSpecification<ProductWithCountAndPrice>(GetProductsByLikeBarcode(findString)
                .Or(GetProductsByContainsVendorCode(findString).Or(GetProductsByLikeTitle(findString)))
                .IsSatisfiedBy());
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByIdGroup(int idGroup)
        {
            return new ExpressionSpecification<ProductWithCountAndPrice>(obj => obj.CategoryId == idGroup);
        }

        public static ExpressionSpecification<ProductWithCountAndPrice> GetProductsByIdGroupOrFindString(int? idGroup, string findString)
        {
            return idGroup == null || idGroup == 0
                ? new ExpressionSpecification<ProductWithCountAndPrice>(GetProductsByFindString(findString).IsSatisfiedBy())
                : new ExpressionSpecification<ProductWithCountAndPrice>(GetProductsByIdGroup(idGroup.Value)
                    .And(GetProductsByFindString(findString)).IsSatisfiedBy());
        }
    }
}
