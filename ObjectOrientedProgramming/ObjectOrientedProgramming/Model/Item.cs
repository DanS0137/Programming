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
    [Serializable]
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        public event EventHandler NameChanged;
        public event EventHandler CostChanged;
        public event EventHandler InfoChanged;

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
        private string _name = "";
        /// <summary>
        /// Информация о предмете.
        /// </summary>
        private string _info = "";
        /// <summary>
        /// Цена предмета.
        /// </summary>
        private double _cost = 0;

        /// <summary>
        /// Возвращает и задаёт категорию предмета.
        /// </summary>
        public Category Category { get; set; } = Category.Attack;

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
                if (value != _name)
                {
                    Services.ValueValidator.AssertStringOnLength(value, 200, "Item.Name");
                    _name = value;
                    NameChanged?.Invoke(this, new EventArgs());
                }
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
                if (value != _info)
                {
                    Services.ValueValidator.AssertStringOnLength(value, 1000, "Item.Info");
                    _info = value;
                    InfoChanged?.Invoke(this, new EventArgs());
                }
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
                if (value != _cost)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Item"/>. Использовать только для создания
        /// экземпляра на основе данных из файла.
        /// </summary>
        /// <param name="id">Уникальный идентификатор. Уникальность не проверяется.</param>
        /// <param name="name">Название. Должно состоять менее чем из 200 символов.</param>
        /// <param name="info">Информация. Должно состоять менее чем из 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть вещественным числом
        /// в диапозоне от 0 до 100000 включительно.</param>
        /// <param name="category">Категория товара.</param>
        public Item(int id, string name, Category category, string info, double cost)
        {
            _id = id;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allIds.Add(id);
        }
        /// <summary>
        /// Создаёт объект класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно состоять менее чем из 200 символов.</param>
        /// <param name="info">Информация. Должно состоять менее чем из 1000 символов.</param>
        /// <param name="cost">Цена. Должно быть вещественным числом
        /// в диапозоне от 0 до 100000 включительно.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, Category category, string info, double cost)
        {
            while (_allIds.Contains(_allItems)) _allItems += 1;
            _id = _allItems;
            _allItems += 1;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
        /// <summary>
        ///  Создаёт объект класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            while (_allIds.Contains(_allItems)) _allItems += 1;
            _id = _allItems;
            _allItems += 1;
        }

        /// <summary>
        /// Создаёт копию объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="Item"/>.</returns>
        public object Clone()
        {
            return new Item(this.Id, this.Name, this.Category, this.Info, this.Cost);
        }
        /// <summary>
        /// Проверяет равны ли объекты класса <see cref="Item"/>.
        /// </summary>
        /// <param name="item">Объект для сравнения.</param>
        /// <returns>Возвращает true, если объект сравнивается сам с собой или их <see cref="Id"/> равны.
        /// Возвращает false, если передавемый объект равен null или их <see cref="Id"/> не равны.</returns>
        public bool Equals(Item item)
        {
            if (item == null)
                return false;
            if (ReferenceEquals(this, item))
                return true;
            if (Id == item.Id)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Сравнивает объекты класса <see cref="Item"/> по свойству <see cref="Cost"/>.
        /// </summary>
        /// <param name="item">Объект для сравнения.</param>
        /// <returns>Возвращает -2, если передаваемый объект равен null.
        /// Возвращвет -1, если цена передаваемого объекта больше.
        /// Возвращает 0, если цены объектов равны.
        /// Возвращает 1, если цена передаваемого объекта меньше.</returns>
        public int CompareTo(Item item)
        {
            if (item == null)
                return -2;
            if (item.Cost == Cost)
                return 0;
            else if (item.Cost > Cost)
                return -1;
            else
                return 1;
        }
    }
}
