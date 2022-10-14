using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YubPack.Mahjong
{
    public class Hai
    {
        int syu;
        int num;

        bool red;

        public int Syu
            { get { return syu; } }
        public int Su
            { get { return num; } }
        public bool Red
            { get { return red; } }

        public Hai(int id)
        {
            if(0 > id || id < )
        }

        public Hai(int syu, int num)
        {
            this.syu = syu;
            this.num = num;
        }

        public Hai(bool red, int syu, int su) : this(syu, su)
        {
            this.red = red;
        }

        public override string ToString()
        {
            string sred = "", ssyu = "", ssu = "";

            if (red)
            {
                sred = "*";
            }

            ssu = num.ToString();

            switch (syu)
            {
                case 0:
                    ssyu = "Ma";
                    break;
                case 1:
                    ssyu = "Pi";
                    break;
                case 2:
                    ssyu = "So";
                    break;
                case 3:
                    switch (num)
                    {
                        case 0:
                            ssu = "E";
                            break ;
                        case 1:
                            ssu = "S";
                            break;
                        case 2:
                            ssu = "W";
                            break;
                        case 3:
                            ssu = "N";
                            break;
                    }
                    break;
                case 4:
                    switch (num)
                    {
                        case 0:
                            ssu = "Haku";
                            break;
                        case 1:
                            ssu = "Hatu";
                            break;
                        case 2:
                            ssu = "Tyun";
                            break;
                    }
                    break;
            }

            return sred + ssyu + ssu;
        }
    }
}
