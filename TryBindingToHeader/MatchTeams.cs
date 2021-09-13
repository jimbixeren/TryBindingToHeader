
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace tryHeaderFoder
{
    class Matchteams : BaseViewModel
    {


        public ICommand FormelFase1Command => new Command(GeamsTeams);

        public string Teams { get; set; }





        public void GeamsTeams()
        {



            //Matchteams Teams = new Matchteams();

            //Teams.Teams = "hej";

        }










        //public ICommand FormelFase1Command => new Command(Klartilatduskrive);


        //private string _teams;

        //public string Teams
        //{
        //    get { return _teams; }
        //    set
        //    {
        //        _teams = value;
        //        OnPropertyChanged();
        //    }

        //}

        //public void Klartilatduskrive()
        //{
        //    Teams = _teams;

        //}





    }
}
