using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class TypeB : TypeA
    {
        #region مع الوراثة
         
        public TypeB() {
            //A = 1  ; // invalid not inherted - Praivate
            //B = 2; // valid inherted internal same Project
            //C = 3; // valid inherted Public 


            //X = 1;
            //Y = 2;
            //Z = 3;
        }



        #endregion



        public void Print()
        {


            #region من غير وراثة
            //TypeA T = new TypeA();
            //T.A = 10;  // invalid [private] 
            //T.B = 20; // invalid [internal] outside Project
            //T.C = 30; // valid [publid] with class Oject and outside Project



            //T.X = 40; // invalid [private Protected]private بتصير بس  Protected من غير وراثة منشيل كلمة 
            //T.Y = 50; // invalid [Proteted]  Protected من غير وراثة منشيل كلمة 
            //T.Z = 60; // invalid [Proteted internal]internal بتضب بس  Protected من غير وراثة منشيل كلمة 
            #endregion


          


        }
    }
}
