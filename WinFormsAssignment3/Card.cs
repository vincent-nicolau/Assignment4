using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsAssignment3
{
    public class Card
    {
        public readonly int Id;
        public readonly Image? CardImage;
        public static readonly Card NO_CARD = new Card(-1, null);
        public Card(int id, Image? image)
        {
            Id = id;
            CardImage = image;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
