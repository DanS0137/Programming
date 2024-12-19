using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Model;
using ObjectOrientedProgramming.Model.Enumerations;

namespace ObjectOrientedProgramming.Model.Orders
{
    [Serializable]
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        public TimeOfDelivery TimeOfDelivery { get; set; }
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса<see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name = "timeOfDelivery" > Желаемое время доставки.</param>
        /// <param name = "dateOfDelivery" > Желаемая дата доставки.</param>
        /// <param name = "address" > Адрес доставки.</param>
        /// <param name = "items" > Список товаров заказа.</param>
        public PriorityOrder(TimeOfDelivery timeOfDelivery, DateTime dateOfDelivery, Address address, List<Item> items) : base(address, items)
        {
            TimeOfDelivery = timeOfDelivery;
            Date = dateOfDelivery;
        }

        public PriorityOrder() : base()
        {

        }
    }
}
