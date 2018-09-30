using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceManApp.Test
{
    public class TestIManAble
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

            //AtTheCinemas(man);
            AtTheCinemas(boy);
        }

        public static void AtTheParty(IMannerAble iMannerAble)
        {
            iMannerAble.Wish();
            iMannerAble.Depart();
        }

        public static void AtTheCinemas(IEmotionAble iEmotionAble)
        {
            iEmotionAble.Cry();
            iEmotionAble.Laugh();
        }
    }
}
