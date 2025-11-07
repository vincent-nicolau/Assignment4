using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAssignment3
{
    internal class Card
    {
        public readonly int Id;
        public readonly Image? image;
        public Card(int id)
        {
            Id = id;         
        }
    }
}
