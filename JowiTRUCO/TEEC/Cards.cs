using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JowiTRUCO.TEEC
{
    class claseCartas
    {
        private int powerCards { get; set; }
        private int typeCards { get; set; }
        private int valueCards { get; set; }
        private string Name { get; set; }
        public claseCartas(int number)
        {
            switch (number)
            {
                case 0:
                    Name = "";
                    valueCards = 0;
                    powerCards = 0;
                    typeCards = 0;
                    break;
                //CARTAS DE ORO.
                case 1:
                    Name = "1 de oro";
                    valueCards = 1;
                    powerCards = 8;
                    typeCards = 1;
                    break;
                case 2:
                    Name = "2 de oro";
                    valueCards = 2;
                    powerCards = 9;
                    typeCards = 1;
                    break;
                case 3:
                    Name = "3 de oro";
                    valueCards = 3;
                    powerCards = 10;
                    typeCards = 1;
                    break;
                case 4:
                    Name = "4 de oro";
                    valueCards = 4;
                    powerCards = 1;
                    typeCards = 1;
                    break;
                case 5:
                    Name = "5 de oro";
                    valueCards = 5;
                    powerCards = 2;
                    typeCards = 1;
                    break;
                case 6:
                    Name = "6 de oro";
                    valueCards = 6;
                    powerCards = 3;
                    typeCards = 1;
                    break;
                case 7:
                    Name = "7 de oro";
                    valueCards = 7;
                    powerCards = 11;
                    typeCards = 1;
                    break;
                case 8:
                    Name = "10 de oro";
                    valueCards = 0;
                    powerCards = 5;
                    typeCards = 1;
                    break;
                case 9:
                    Name = "11 de oro";
                    valueCards = 0;
                    powerCards = 6;
                    typeCards = 1;
                    break;
                case 10:
                    Name = "12 de oro";
                    valueCards = 0;
                    powerCards = 7;
                    typeCards = 1;
                    break;
                //CARTAS DE COPA.       
                case 11:
                    Name = "1 de copa";
                    valueCards = 1;
                    powerCards = 8;
                    typeCards = 2;
                    break;
                case 12:
                    Name = "2 de copa";
                    valueCards = 2;
                    powerCards = 9;
                    typeCards = 2;
                    break;
                case 13:
                    Name = "3 de copa";
                    valueCards = 3;
                    powerCards = 10;
                    typeCards = 2;
                    break;
                case 14:
                    Name = "4 de copa";
                    valueCards = 4;
                    powerCards = 1;
                    typeCards = 2;
                    break;
                case 15:
                    Name = "5 de copa";
                    valueCards = 5;
                    powerCards = 2;
                    typeCards = 2;
                    break;
                case 16:
                    Name = "6 de copa";
                    valueCards = 6;
                    powerCards = 3;
                    typeCards = 2;
                    break;
                case 17:
                    Name = "7 de copa";
                    valueCards = 7;
                    powerCards = 4;
                    typeCards = 2;
                    break;
                case 18:
                    Name = "10 de copa";
                    valueCards = 0;
                    powerCards = 5;
                    typeCards = 2;
                    break;
                case 19:
                    Name = "11 de copa";
                    valueCards = 0;
                    powerCards = 6;
                    typeCards = 2;
                    break;
                case 20:
                    Name = "12 de copa";
                    valueCards = 0;
                    powerCards = 7;
                    typeCards = 2;
                    break;
                //CARTAS DE ESPADA.
                case 21:
                    Name = "1 de espada";
                    valueCards = 1;
                    powerCards = 14;
                    typeCards = 3;
                    break;
                case 22:
                    Name = "2 de espada";
                    valueCards = 2;
                    powerCards = 9;
                    typeCards = 3;
                    break;
                case 23:
                    Name = "3 de espada";
                    valueCards = 3;
                    powerCards = 10;
                    typeCards = 3;
                    break;
                case 24:
                    Name = "4 de espada";
                    valueCards = 4;
                    powerCards = 1;
                    typeCards = 3;
                    break;
                case 25:
                    Name = "5 de espada";
                    valueCards = 5;
                    powerCards = 2;
                    typeCards = 3;
                    break;
                case 26:
                    Name = "6 de espada";
                    valueCards = 6;
                    powerCards = 3;
                    typeCards = 3;
                    break;
                case 27:
                    Name = "7 de espada";
                    valueCards = 7;
                    powerCards = 12;
                    typeCards = 3;
                    break;
                case 28:
                    Name = "10 de espada";
                    valueCards = 0;
                    powerCards = 5;
                    typeCards = 3;
                    break;
                case 29:
                    Name = "11 de espada";
                    valueCards = 0;
                    powerCards = 6;
                    typeCards = 3;
                    break;
                case 30:
                    Name = "12 de espada";
                    valueCards = 0;
                    powerCards = 7;
                    typeCards = 3;
                    break;
                //CARTAS DE BASTO.
                case 31:
                    Name = "1 de basto";
                    valueCards = 1;
                    powerCards = 13;
                    typeCards = 4;
                    break;
                case 32:
                    Name = "2 de basto";
                    valueCards = 2;
                    powerCards = 9;
                    typeCards = 4;
                    break;
                case 33:
                    Name = "3 de basto";
                    valueCards = 3;
                    powerCards = 10;
                    typeCards = 4;
                    break;
                case 34:
                    Name = "4 de basto";
                    valueCards = 4;
                    powerCards = 1;
                    typeCards = 4;
                    break;
                case 35:
                    Name = "5 de basto";
                    valueCards = 5;
                    powerCards = 2;
                    typeCards = 4;
                    break;
                case 36:
                    Name = "6 de basto";
                    valueCards = 6;
                    powerCards = 3;
                    typeCards = 4;
                    break;
                case 37:
                    Name = "7 de basto";
                    valueCards = 7;
                    powerCards = 4;
                    typeCards = 4;
                    break;
                case 38:
                    Name = "10 de basto";
                    valueCards = 0;
                    powerCards = 5;
                    typeCards = 4;
                    break;
                case 39:
                    Name = "11 de basto";
                    valueCards = 0;
                    powerCards = 6;
                    typeCards = 4;
                    break;
                case 40:
                    Name = "12 de basto";
                    valueCards = 0;
                    powerCards = 7;
                    typeCards = 4;
                    break;
                default:
                    Name = "Error";
                    break;
            }
        }
        public int getTypeCards()
        {
            return typeCards;
        }
        public int getValueCards()
        {
            return valueCards;
        }
        public int getPowerCards()
        {
            return powerCards;
        }
        public string getName()
        {
            return Name;
        }
    }
}
