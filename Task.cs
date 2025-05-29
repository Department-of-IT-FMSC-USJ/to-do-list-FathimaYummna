using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace To_Do_List_
{
    class Task
    {
        public string name;
        public int ID;
        public string description;
        public string date;
        public string status = "To Do";
    

    public Task(int id, string name, string description, DateTime date) {
            {
                ID = id;
                name = name;
                description = description;
                date = date;
                status = "To Do";
            }
        }


        public override string ToString()
        {
            return $"[{status}] ID: {ID}, Name: {name}, Date: {date},Description: {description}";
        }

    }
}