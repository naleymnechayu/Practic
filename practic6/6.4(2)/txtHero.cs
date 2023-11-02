using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class txtHero:AllHero
    {
        protected Dictionary<int,string> idAbout = new Dictionary<int,string>();

        protected Dictionary<int, string> addinfoAbout()
        {
            idAbout[Id] = GetAboutText();
            return idAbout;
        }


        private string GetAboutText()
        {
            switch (Name)
            {
                case "Axe":
                    return "АКС - АТТАКСС";
                case "Pudge":
                    return "Имеет при себе длинный хук";
                case "Puck":
                    return "Имба патча - попробуй догони";
                case "Tinker":
                    return "Дядя Федор";
                case "Zeus":
                    return "Бог этого мира";
                case "Bane":
                    return "Спать";

                default:   
                    return "Описание для данного героя пока не добавлено";
            }
        }
    }
}
