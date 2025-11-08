using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics.CodeAnalysis;

namespace WinFormsAssignment3
{
    public class Card
    {
        public readonly int Id;
        public readonly Image? CardImage;
        public static readonly Card NO_CARD = new Card(-1, null, "No Card");
        public readonly string Name;
        public Card(int id, Image? image, string name)
        {
            Id = id;
            CardImage = image;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
