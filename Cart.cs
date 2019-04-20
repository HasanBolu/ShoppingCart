using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class BasketItem
    {
        public Product Product { get; set; }

        public int Amount { get; set; }
    }

    class Cart
    {
        public double TotalCampaignDiscount { get; set; }

        public double DeliveryCost { get; set; }

        public double CouponDiscount { get; set; }

        public double CostWithoutDiscount { get; set; }

        public double FinalCost { get; set; }

        public List<BasketItem> Basket { get; set; }


        public double GetTotalAmountAfterDiscount()
        {
            return this.CostWithoutDiscount - this.TotalCampaignDiscount - this.CouponDiscount;
        }

        public void ApplyDiscounts(params double[] discounts)
        {
            foreach (var discount in discounts)
            {
                this.TotalCampaignDiscount += discount;
            }
        }

        public void ApplyCoupon(Coupon coupon)
        {
            if (this.CostWithoutDiscount >= coupon.MinShoppingAmount)
            {
                if (coupon.DiscountType == DiscountType.Amount)
                {
                    this.CouponDiscount = coupon.DiscountAmount;
                }
                else if (coupon.DiscountType == DiscountType.Rate)
                {
                    this.CouponDiscount = (this.CostWithoutDiscount * coupon.DiscountAmount) / 100;
                }
            }
        }

        public void AddItem(Product product, int amount)
        {
            var productWithAmount = new BasketItem() { Product = product, Amount = amount};
            this.Basket.Add(productWithAmount);
        }

        public double GetDeliveryCost()
        {
            return this.DeliveryCost;
        }

        public double GetCampaignDiscount()
        {
            return this.TotalCampaignDiscount;
        }

        public double GetCouponDiscount()
        {
            return this.CouponDiscount;
        }

        public void Print()
        {
            Console.WriteLine("Cost without discount: " + this.CostWithoutDiscount);
            Console.WriteLine("Total campaign discount: " + this.TotalCampaignDiscount);
            Console.WriteLine("Coupon discount: " + this.CouponDiscount);
            Console.WriteLine("Delivery cost: " + this.DeliveryCost);
            Console.WriteLine("Final cost: " + this.FinalCost);
        }
    }
}
