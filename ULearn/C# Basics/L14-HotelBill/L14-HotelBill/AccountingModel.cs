/* В файле AccountingModel.cs создайте класс AccountingModel, унаследованный от ModelBase, со следующими свойствами.
    double Price — цена за одну ночь. Должна быть неотрицательной.
    int NightsCount — количество ночей. Должно быть положительным.
    double Discount — скидка в процентах. Никаких дополнительных ограничений.
    double Total — сумма счёта. Должна быть не отрицательна и должна быть согласована с предыдущими тремя свойствами по правилу: 
    Total == Price * NightsCount * (1-Discount/100).
Все поля должны иметь сеттеры. При установке Price, NightsCount и Discount должна соответствующим образом устанавливаться Total, 
при установке Total — соответствующим образом меняться Discount. В случае установки значения, нарушающего хоть одно условие целостности, 
необходимо выкидывать ArgumentException.
При изменении значения любого свойства необходимо дополнительно сигнализировать об этом с помощью вызова метода Notify, 
передавая ему имя изменяемого свойства. Здесь можно воспользоваться ключевым словом nameof. */

using System;

namespace HotelAccounting
{
    public class AccountingModel : ModelBase
    {
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid Price!");
                price = value;
                Notify(nameof(Price));
                CalculateTotal();
            }
        }
        private int nightsCount;
        public int NightsCount
        {
            get { return nightsCount; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Number of days!");
                nightsCount = value;
                Notify(nameof(NightsCount));
                CalculateTotal();
            }
        }
        private double discount;
        public double Discount
        {
            get { return discount; }
            set
            {
                if (value < -100 || value > 100)
                    throw new ArgumentException("Invalid Discount!");
                discount = value;
                Notify(nameof(Discount));
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            total = price * nightsCount * (1 - discount / 100);
            Notify(nameof(Total));
        }

        private double total;
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid Value!");
                total = value;
                Notify(nameof(Total));
                discount = 100 - ((100 * total) / (price * nightsCount));
                Notify(nameof(Discount));
            }
        }
    }
}
