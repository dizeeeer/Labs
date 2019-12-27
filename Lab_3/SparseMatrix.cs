﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Matrix<T>
    {
            /// <summary>
            /// Словарь для хранения значений
            /// </summary>
            Dictionary<string, T> _matrix = new Dictionary<string, T>();

            /// <summary>
            /// Количество элементов по горизонтали (максимальное количество столбцов)
            /// </summary>
            int maxX;

            /// <summary>
            /// Количество элементов по вертикали (максимальное количество строк)
            /// </summary>
            int maxY;

        /// <summary>
        /// Реализация интерфейса для проверки пустого элемента 
        /// </summary>
        IMatrixCheckEmpty<T> сheckEmpty;


        /// <summary>
        /// Конструктор
        /// </summary>
        public Matrix(int px, int py, IMatrixCheckEmpty<T> сheckEmptyParam)
            {
                this.maxX = px;
                this.maxY = py;
                this.сheckEmpty = сheckEmptyParam;
        }

            /// <summary>
            /// Индексатор для доступа к данных
            /// </summary>
            public T this[int x, int y]
            {
                set
                {
                    CheckBounds(x, y);
                    string key = DictKey(x, y);
                    this._matrix.Add(key, value);
                }
                get
                {
                    CheckBounds(x, y);
                    string key = DictKey(x, y);
                    if (this._matrix.ContainsKey(key))
                    {
                        return this._matrix[key];
                    }
                    else
                    {
                        return this.сheckEmpty.getEmptyElement();
                    }
                }
                
            }

        /// <summary>
        /// Проверка границ
        /// </summary>
        void CheckBounds(int x, int y)
        {
            if (x < 0 || x >= this.maxX) throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
        }
            /// <summary>
            /// Формирование ключа
            /// </summary>
            string DictKey(int x, int y)
            {
                return x.ToString() + "_" + y.ToString();
            }

            /// <summary>
            /// Приведение к строке
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                StringBuilder b = new StringBuilder();
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0)
                        {
                            b.Append("\t");
                        }
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j]))
                        {
                            b.Append(this[i, j].ToString());
                        }
                        else
                        {
                            b.Append(" - ");
                        }   
                    }
                    b.Append("]\n");
                }
            return b.ToString();
            }
    }
}
