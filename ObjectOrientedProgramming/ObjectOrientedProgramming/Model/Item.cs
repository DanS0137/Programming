using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Model
{
    /// <summary>
    /// Хранит данные о неком предмете.
    /// </summary>
    class Item
    {
        /// <summary>
        /// Количество объектов класса.
        /// </summary>
        private static int _allItems = 0;
        /// <summary>
        /// Все использованные уникальные идентификаторы.
        /// </summary>
        private static List<int> _allIds = new List<int>();

        /// <summary>
        /// Уникальный идентификатор объекта класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _name;
        /// <summary>
        /// Информация о предмете.
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена предмета.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор объекта класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }
        /// <summary>
        /// Возвращает и задаёт название предмета. Должно состоять менее чем из 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200, "Item.Name");
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт какую-либо информацию о предмете.
        /// Должно состоять менее чем из 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 1000, "Item.Info");
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт цену предмета. Должно быть вещественным числом
        /// в диапозоне от 0 до 100000 включительно.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException();
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Item"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор. Уникальность не проверяется.</param>
        /// <param name="name">Название. Должно состоять менее чем из 200 символов.</param>
        /// <param name="info">Информация. Должно состоять менее чем из 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть вещественным числом
        /// в диапозоне от 0 до 100000 включительно.</param>
        public Item(int id, string name, string info, double cost)
        {
            _id = id;
            Name = name;
            Info = info;
            Cost = cost;
            _allIds.Add(id);
        }
        /// <summary>
        /// Создаёт объект класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно состоять менее чем из 200 символов.</param>
        /// <param name="info">Информация. Должно состоять менее чем из 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть вещественным числом
        /// в диапозоне от 0 до 100000 включительно.</param>
        public Item(string name, string info, double cost)
        {
            while (_allIds.Contains(_allItems)) _allItems += 1;
            _id = _allItems;
            _allItems += 1;
            Name = name;
            Info = info;
            Cost = cost;
        }
        /// <summary>
        ///  Создаёт объект класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            while (_allIds.Contains(_allItems) == true) _allItems += 1;
            _id = _allItems;
            _allItems += 1;
        }
    }
}
