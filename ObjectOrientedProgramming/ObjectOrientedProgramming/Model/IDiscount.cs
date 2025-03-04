using System.Collections.Generic;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Предоставляет возможность одновременной работы с классами 
    /// <see cref="PointsDiscount"/> и <see cref="PercentsDiscount"/>.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// возвращает информацию о скидке.
        /// </summary>
        string Info { get; }
        /// <summary>
        /// Считает значение скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает значение скидки.</returns>
        double Calculate(List<Item> items);
        /// <summary>
        /// Выполняет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает значение скидки.</returns>
        double Apply(List<Item> items);
        /// <summary>
        /// Перерасчитывает возможную скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
