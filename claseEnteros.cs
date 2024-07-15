using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosEnteros
{
    class claseEnteros
    {
        // Atributos
        private int number;

        // Constructor
        public claseEnteros()
        {
            number = 0;
        }

        // Metodos de la clase numero entero:
        // cargar
        public void set_Date(int date)
        {
            number = date;
        }
        // descargar
        public int get_Date()
        {
            int result = this.number; // Tambien puede ser de forma directa: "return number"
            return result;
        }
        // cargar Random
        public void set_dateRandom(int min, int max)
        {
            Random varRandom = new Random();
            this.number = varRandom.Next(min, max + 1);
        }
        // Verificando si los numeros son pares: ************************************
        // Verificar numeros pares sin parametro
        public bool verify_ParOne()
        {
            int residuo;
            bool answer = false;

            residuo = this.number % 2;
            if (residuo == 0) // Si queremos los impares solo cambiamos el 0 por 1 o usamos "!=0"
            {
                answer = true;
            }
            return answer;
        }
        // Verificar numeros pares con parametro
        public bool verify_ParTwo(int date)
        {
            bool answer = false;
            if (date % 2 == 0)
            {
                answer = true;
            }
            return answer;
        }

        // ***************************************************************************

        // Verificando si los numero son primos **************************************
        // Verificar numeros primos sin parametro
        public bool verify_PrimosOne()
        {
            int counter, residuo; bool answer = false;
            counter = 0;

            for (int idx = 1; idx <= this.number; idx++)
            {
                residuo = this.number % idx;
                if (residuo == 0)
                    counter++;
            }
            if (counter == 2)
                answer = true;
            return answer;
        }
        // Verificando numeros primos con parametro
        public bool verify_PrimosTwo(int date)
        {
            int counter = 0;
            bool answer = false;

            for(int idx = 1; idx <= date; idx++)
            {
                if (date % idx == 0)
                    counter++;
            }
            if (counter == 2)
                answer = true;
            return answer;
        }
        // ***************************************************************************
        // Invertir numeros enteros
        // Invertir numeros enteros sin parametro
        public void reverse_NumberOne()
        {
            int digit, varNumber2 = 0;           
            while(this.number > 0)
            {
                digit = this.number % 10;
                varNumber2 = varNumber2 * 10 + digit;
                this.number = this.number / 10;
            }
            this.number = varNumber2;
        }
        // Invertir numeros enteros con parametro
        public void reverse_NumberTwo(int date)
        {
            int digit, varNumber2 = 0;
            while(date > 0)
            {
                digit = date % 10;
                varNumber2 = varNumber2 * 10 + digit;
                date = date / 10;
            }
            this.number = varNumber2;
        }
        // ***************************************************************************
        // Verificar si los numeros enteros son capicua
        // Verificar si es capicua metodo 1: directo

        public bool verify_CapicuaOne()
        {
            // Instanciamos un objeto
            claseEnteros newNumber = new claseEnteros();
            newNumber.set_Date(this.number);
            newNumber.reverse_NumberOne();
            return (this.number == newNumber.number);
        }
        // Verificar si es capicua metodo 2: usando condicional
        public bool verify_CapicuaTwo()
        {
            // Instanciamos un objeto
            claseEnteros newNumber = new claseEnteros();
            bool answer = false;

            newNumber.set_Date(this.number);
            newNumber.reverse_NumberOne();

            if(this.number == newNumber.number)
            {
                answer = true;
            }
            return answer;
        }
        // Verificar si es capicua metodo 3: largo, con bucle y condicional
        public bool verify_CapicuaThree()
        {
            // Instanciamos un objeto
            claseEnteros newNumber = new claseEnteros();
            // Inicializamos el nuevo objeto
            newNumber.set_Date(this.number);

            int numberOriginal, numberResult, digit, date;
            bool answer = false;

            numberOriginal = newNumber.number; numberResult = 0; date = newNumber.number;

            while (date > 0)
            {
                digit = date % 10;
                numberResult = (numberResult * 10) + digit;
                date = date / 10;
            }
            if(numberOriginal == numberResult)
            {
                answer = true;
            }
            return answer;

        }
        // Verificar si es capicua metodo 4: largo, con bucle, condicional y con parametro
        public bool verify_CapicuaFour(int varNumber)
        {
            // No instanciamos ningun objeto
            int numberOriginal, numberResult, digit, date;
            bool answer = false;

            numberOriginal = varNumber; numberResult = 0; date = varNumber;
            while(date > 0)
            {
                digit = date % 10;
                numberResult = (numberResult * 10) + digit;
                date = date / 10;
            }
            if (numberOriginal == numberResult)
            {
                answer = true;
            }
            varNumber = date;
            return answer;
        }
        // ***************************************************************************

        // Verificamos si un numero pertenece en otro numero entero
        // Metodo 1: usando un "do while"
        public bool number_BelongsOne(int varNumber)
        {
            int auxi, digit;
            bool answer = false;

            auxi = this.number;
            do
            {
                digit = this.number % 10;
                this.number = this.number / 10;
            } while (!((digit == varNumber) || (this.number == 0)));
            if (digit == varNumber)
                answer = true;
            this.number = auxi;
            return answer;
        }
        // Metodo 2: usando solo "while"
        public bool number_BelongsTwo(int varNumber)
        {
            int auxi, digit; bool answer = false;
            auxi = this.number;

            while((this.number > 0) && (answer == false))
            {
                digit = this.number % 10;
                this.number = this.number / 10;
                if (digit == varNumber)
                    answer = true;
            }
            this.number = auxi;
            return answer;
        }
        // ***************************************************************************

        public void number_Intersection(claseEnteros numberOne, ref claseEnteros numberResult)
        {
            int digit, auxi;
            numberResult.number = 0; auxi = this.number;

            while(this.number > 0)
            {
                digit = this.number % 10;
                this.number = this.number / 10;
                if(numberOne.number_BelongsOne(digit) == true)
                {
                    numberResult.number = numberResult.number * 10 + digit;
                }
            }
            this.number = auxi;
        }
    }
}
