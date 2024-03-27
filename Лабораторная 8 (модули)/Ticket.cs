using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8__модули_
{
    class Ticket
    {
        public List<string> Tickets { get; set; } // хранение списка билетов
        public List<string> Tasks { get; set; } // хранение списка заданий
        public List<string> Answer { get; set; } // хранение списка ответов
        public List<string> Question { get; set; } // хранение списка вопросов
        public Ticket() { }
    }
}
