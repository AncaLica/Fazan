using System;
using System.Collections.Generic;
using System.Linq;

namespace fazan
{
    internal class Validare
    {
       

        private List<string> Dictionar { get; set; } // lista cu cuvintele din txt

        //numa metoda VerifyInput se mosteneste mai departe
        protected string VerifyInput(string input)
        {
            string msg = "null";

            if (VerificareSimboluri(input))// verifica daca ai  simboluri
            {
                if (ValidareNumar(input))  // verifica daca ai numere
                {
                    FillDictionarFromTxt(); //adu din txt dictionaru si add local in lista

                    if (Dictionar.Contains(input)) // vezi daca cuvantul tau este in dictionar
                    {
                        msg = "OK"; // tot ii bine si frumos 
                    }
                    else
                    {
                        msg = "Cuvatul tau nu exista";
                    }

                }

                else
                {
                    msg= "Cuvantul tau nu trebuie sa cuprinda numere";
                }
            }
            else
            { msg= "Cuvantul tau nu trebuie sa cuprinda simboluri"; }


            return msg;
        } 

        private void FillDictionarFromTxt()
        {
            string line;

            string Path = @".\..\..\InputData\Dictionar.txt"; // dai calea spre fisier
            System.IO.StreamReader file = new System.IO.StreamReader(Path);// citeste fisieru 

            while ((line = file.ReadLine()) != null) // citeste linie cu linie din fisier pana cand ai ajuns la final de fisier
            {
                Dictionar.Add(line); // adauga fiecare linie din fiser in Dictionar
            }


        }

        private bool ValidareNumar(string input) // daca nu ii numar return true
        {
            foreach (var caracter in input)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (caracter == i)
                    { return false; }
                }
            }
            return true;
        }

        private bool VerificareSimboluri(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (var item in specialChar)
            {
                if (input.Contains(item))
                { return false; }
            }

            return true;
        }



    }
}