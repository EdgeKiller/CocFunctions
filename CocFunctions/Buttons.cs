using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocFunctions
{
    public class Buttons
    {
        public static Point GetPos(string name, int xDif, int yDif)
        {
            switch (name)
            {
                //Home buttons
                case "attack": //Attack button at home
                    return new Point(40 + xDif, 630 + yDif);
                case "disable_shield": //Disable shield button
                    return new Point(520 + xDif, 410 + yDif);
                case "next": //Next village button
                    return new Point(750 + xDif, 530 + yDif);
                case "find_match": //Find match button
                    return new Point(220 + xDif, 535 + yDif);

                //Selection buttons (Upgrade/Train troops...)
                case "4_4": //Button 4 if 4 buttons
                    return new Point(570 + xDif, 620 + yDif);
                case "5_5": //Button 5 if 5 buttons
                    return new Point(620 + xDif, 620 + yDif);
                case "3_3": //Button 3 if 3 buttons
                    return new Point(522 + xDif, 620 + yDif);


                case "endbattle":
                    return new Point(60 + xDif, 540 + yDif);

                //Troops Buttons
                case "troop0": //Button train Barbarian
                    return new Point(240 + xDif, 345 + yDif);
                case "troop1": //Button train Archer
                    return new Point(340 + xDif, 345 + yDif);
                case "troop2": //Button train Giant
                    return new Point(440 + xDif, 345 + yDif);
                case "troop3": //Button train Goblin
                    return new Point(550 + xDif, 345 + yDif);
                case "troop4": //Button train Wall Breaker
                    return new Point(640 + xDif, 345 + yDif);
                case "troop5": //Button train Balloon
                    return new Point(240 + xDif, 450 + yDif);
                case "troop6": //Button train Wizard
                    return new Point(340 + xDif, 450 + yDif);
                case "troop7": //Button train Healer
                    return new Point(440 + xDif, 450 + yDif);
                case "troop8": //Button train Dragon
                    return new Point(540 + xDif, 450 + yDif);
                case "troop9": //Button train P.E.K.K.A
                    return new Point(640 + xDif, 450 + yDif);
                case "troop_ready":
                    return new Point(140 + xDif, 520 + yDif);


                default:
                    return new Point(-1, -1);
            }
        }

        public static Rectangle GetResourcesRec(string name, int xDif, int yDif)
        {
            switch (name)
            {
                case "gold":
                    return new Rectangle(51 + xDif, 92 + yDif, 80, 20);
                case "elixir":
                    return new Rectangle(51 + xDif, 121 + yDif, 80, 20);
                case "dark":
                    return new Rectangle(51 + xDif, 148 + yDif, 50, 20);
                case "trophy":
                    return new Rectangle(51 + xDif, 152 + yDif, 30, 20);
                case "trophy_dark":
                    return new Rectangle(51 + xDif, 181 + yDif, 30, 20);
                case "player_trophy":
                    return new Rectangle(61 + xDif, 97 + yDif, 45, 20);
                default:
                    return new Rectangle(-1, -1, -1, -1);
            }
        }

        public static Rectangle GetGainRec(string name, int xDif, int yDif)
        {
            switch (name)
            {
                case "gold":
                    return new Rectangle(350 + xDif, 312 + yDif, 96, 28);
                case "elixir":
                    return new Rectangle(350 + xDif, 350 + yDif, 96, 28);
                case "dark":
                    return new Rectangle(388 + xDif, 388 + yDif, 60, 28);
                default:
                    return new Rectangle(-1, -1, -1, -1);
            }
        }
    }


}
