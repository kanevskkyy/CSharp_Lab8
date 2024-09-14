using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
        abstract class Food
        {
            public int Quantity { get; }

            protected Food(int quantity)
            {
                Quantity = quantity;
            }
        }

        class Vegetable : Food
        {
            public Vegetable(int quantity) : base(quantity) { }
        }

        class Fruit : Food
        {
            public Fruit(int quantity) : base(quantity) { }
        }

        class Meat : Food
        {
            public Meat(int quantity) : base(quantity) { }
        }

        class Seeds : Food
        {
            public Seeds(int quantity) : base(quantity) { }
        }

    }