using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Duration
    {
        #region Attribute
        private int hours;
        private int minutes;
        private int seconds;

        #endregion
        #region Properties
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set { seconds = value;
                while (seconds >= 60) {
                    minutes = minutes + seconds / 60;
                    seconds = seconds % 60;

                }

                while (minutes >= 60)
                {
                    Hours = hours + minutes / 60;
                    minutes = minutes % 60;
                }

            }
        }

      
       public int Minutes { get {  return minutes; } 
            
            set { 
            minutes = value;
                while (minutes >= 60) { 
                Hours = hours + minutes / 60;
                    minutes = minutes % 60;
                }
            
            } }

        public int Hours
        {
            get { return hours; }

            set
            {
                hours = value;
            }
        }


        #endregion




        #region methods
        public override string ToString()
        {
            if(hours != 0)
            {
                return $"Hours:{Hours} Minutes:{Minutes} Seconds:{Seconds}";
            }
           else if(minutes != 0)
            {
                return $"Minutes:{Minutes} Seconds:{Seconds}";
            }
            else
            {
                return $"Seconds:{Seconds}";
            }
        }




        #endregion


        #region Constrauctors
        
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Seconds = seconds;  
        }
        #endregion
        public Duration()
        {
            Hours = Minutes = Seconds = 0 ;
        }

        #region Operator Overloading


        public static Duration operator + (Duration d1, Duration d2)
        {

            return new Duration()
            {
                Hours = (d1?.Hours ?? 0) + (d2?.Hours ?? 0),
                Minutes = (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };

        }


        //public static Duration operator +(Duration d1, int seconds)
        //{
        //    return new Duration()
        //    {


        //    };

        //}

        #endregion

    }
}
