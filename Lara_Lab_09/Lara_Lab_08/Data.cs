using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lara_Lab_08
{
    public struct Person
    {//public structure
        public string fName;//holds the name
        public string lName;//holds the last name
        public string street;//holds the street
        public string city;//holds the city
        public string state;//holds the state
        public string zip;//holds the zip
        public string phone;//holds the phone
        public string email;//holds the email
    }

    class Data
    {
        //stores the list of lines coming from file
        public static List<string> _lstPer = new List<string>();
        //creates a person structure instance
        public Person _struPerson = new Person();
        //holds the current table opened
        public static int _recCurrent;
        //holds the number of the new person only used in add form
        public static int newPerNum;

        public void _setPersonL(string per)
        {
            //lets us add an entry to the list
            _lstPer.Add(per);
        }
        public List<string> _getPersonL()
        {
            //lets us use an entry to the list
            return _lstPer;
        }
        //this will be used in lab 9
        public void _removeAt_listPer(int index)
        {
            _lstPer.RemoveAt(index);
           
        }
        public void _insertAt_listPer(int index, string str)
        {
            _lstPer.Insert(index, str);
        }
        

        public void _setListToStru(int index)
        {//sets the selcted list item to the structure, that way the info can be displayed
            
            //used to separate tokens
            char delim = ',';
            //holds a array of strings of the line selected
            string[] tokens = _lstPer[index].Split(delim);
            //sets the name to the structure
            _struPerson.fName = tokens[0];
            //sets the last name to the structure
            _struPerson.lName = tokens[1];
            //sets the street to the structure
            _struPerson.street = tokens[2];
            //sets the city to the structure
            _struPerson.city = tokens[3];
            //sets the state to the structure
            _struPerson.state = tokens[4];
            //sets the zip to the structure
            _struPerson.zip = tokens[5];
            //sets the phone to the structure
            _struPerson.phone = tokens[6];
            //sets the email to the structure
            _struPerson.email = tokens[7];
        }


    }
}
