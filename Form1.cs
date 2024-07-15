using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace numerosEnteros
{
    public partial class Form1 : Form
    {
        // Usamos el nombre de la clase para agregar objetsos
        claseEnteros objNum1, objNum2, objNum3;

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objNum1.set_Date(int.Parse(textBox1.Text));
            }
            catch
            {
                Interaction.MsgBox("Sin dato, ingrese el numero!!");
            }
        }

        private void descargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(objNum1.get_Date());
        }

        private void cargarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                objNum2.set_Date(int.Parse(textBox2.Text));
            }
            catch
            {
                Interaction.MsgBox("Sin dato, ingrese el numero!!");
            }
        }

        private void descargarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(objNum2.get_Date());
        }

        private void cargarDatosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                objNum3.set_Date(int.Parse(textBox3.Text));
            }
            catch
            {
                Interaction.MsgBox("Sin dato, ingrese el numero!!");
            }
        }

        private void descargarDatosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(objNum3.get_Date());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void cargarDatoRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objNum1.set_dateRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox4.Text = string.Concat(objNum1.get_Date());
            }
            catch
            {
                Interaction.MsgBox("Ingrese los datos correctamente...");
            }   
        }

        private void verificarSiEsParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se puede realizar de las dos formas, usar uno y luego comentar el otro
            //textBox4.Text = string.Concat(objNum1.verify_Par());
           
            if (objNum1.verify_ParOne() == true)
            {
                textBox4.Text = "El numero es par !!";
            }
            else
            {
                textBox4.Text = "El numero no es par...";
            }
        }
        private void verificarParconParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se puede realizar de las dos formas, usar uno y luego comentar el otro
            try
            {
                //textBox4.Text = string.Concat(objNum1.verify_ParTwo(int.Parse(textBox1.Text)));
                if (objNum1.verify_ParTwo(int.Parse(textBox1.Text)) == true)
                    textBox4.Text = "El numeros es PAR!!";
                else
                    textBox4.Text = "El numero NO es PAR..";
            }
            catch
            {
                Interaction.MsgBox("Ingrese los datos correctamente!");
            }
        }
        private void verificarPrimoconParamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Se puede realizar de las dos formas, usar uno y luego comentar el otro
            try
            {
                //textBox4.Text = string.Concat(objNum1.verify_PrimosTwo(int.Parse(textBox1.Text)));
                if (objNum1.verify_PrimosTwo(int.Parse(textBox1.Text)) == true)
                    textBox4.Text = "El numero es PRIMO!!";
                else
                    textBox4.Text = "El numero NO es PRIMO..";
                   
            }
            catch
            {
                Interaction.MsgBox("Ingrese los datos correctamente!");
            }
        }

        private void verificarPrimosinParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se puede realizar de las dos formas, usar uno y luego comentar el otro
            //textBox4.Text = string.Concat(objNum1.verify_PrimosOne());
            
            if(objNum1.verify_PrimosOne() == true)
            {
                textBox4.Text = "El numero es primo!!";
            }
            else
            {
                textBox4.Text = "El numero no es primo...";
            }
        }

        private void invertirNumerosinParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objNum1.reverse_NumberOne();
            textBox4.Text = string.Concat(objNum1.get_Date());           
        }

        private void invertirNumeroconParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objNum1.reverse_NumberTwo(int.Parse(textBox1.Text));
                textBox4.Text = string.Concat(objNum1.get_Date());
            }
            catch
            {
                Interaction.MsgBox("Sin datos, ingrese los datos correctamente");
            }
        }

        private void verificarSiEsCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Con la siguiente funcion podemos usar cada uno de los metodos de "verificar capicua"
            try
            {
                int varNumber;
                varNumber = Convert.ToChar(Interaction.InputBox("Ingrese el numero del metodo que quiera usar:"
                    + "\x000d" + "\x000a" + "Metodo: 1" + "\x000d" + "\x000a" + "Metodo: 2" + "\x000d" + "\x000a" + "Metodo: 3" + "\x000d" + "\x000a" + "Metodo: 4"));
                
                if (varNumber == '1')
                {
                    // Podemos usar cualquier metodo, solo comentamos uno y usamos el otro
                    //textBox4.Text = string.Concat(objNum1.verify_CapicuaOne());
                    if (objNum1.verify_CapicuaOne() == true)
                        textBox4.Text = "Metodo 1: es capicua!!";
                    else
                        textBox4.Text = "Metodo 1: NO es capicua...";
                }
                else if(varNumber == '2')
                {
                    // Podemos usar cualquier metodo, solo comentamos uno y usamos el otro
                    //textBox5.Text = string.Concat(objNum1.verify_CapicuaTwo());
                    if (objNum1.verify_CapicuaTwo() == true)
                        textBox5.Text = "Metodo 2: es capicua!!";
                    else
                        textBox5.Text = "Metodo 2: NO es capicua!!...";
                }
                else if(varNumber == '3')
                {
                    // Podemos usar cualquier metodo, solo comentamos uno y usamos el otro
                    //textBox6.Text = string.Concat(objNum1.verify_CapicuaThree());
                    if (objNum1.verify_CapicuaThree() == true)
                        textBox6.Text = "Metodo 3: es capicua!!";
                    else
                        textBox6.Text = "Metodo 3: NO es capicua...";
                }
                else if(varNumber == '4')
                {
                    try
                    {
                        // Podemos usar cualquier metodo, solo comentamos uno y usamos el otro
                        //textBox7.Text = string.Concat(objNum1.verify_CapicuaFour(int.Parse(textBox1.Text)));
                        if (objNum1.verify_CapicuaFour(int.Parse(textBox1.Text)) == true)
                            textBox7.Text = "Metodo 4: es capicua!!";
                        else
                            textBox7.Text = "Metodo 4: No es capicua...";
                    }
                    catch
                    {
                        Interaction.MsgBox("Primero ingrese el parametro...");
                    }
                    
                }
            }
            catch
            {
                Interaction.MsgBox("Se cancelo la operacion...");
            }
            // Se realizo de la siguiente manera para no realizar muchos llamados en el "Form1.cs [Diseño]"
        }

        private void verificarSiPerteneceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Con la siguiente funcion podemos usar las dos funciones de "pertenece"
            try
            {
                int varNumber;
                varNumber = Convert.ToChar(Interaction.InputBox("Ingrese el numero de la opcion: " + "\x000d" + "\x000a" + "Metodo: 1" + "\x000d" + "\x000a" + "Metodo: 2"));
                if (varNumber == '1')
                {
                    try
                    {
                        textBox4.Text = string.Concat(objNum1.number_BelongsOne(int.Parse(textBox2.Text)));
                    }
                    catch
                    {
                        Interaction.MsgBox("Primero ingrese los parametros...");
                    }
                }        
                else if (varNumber == '2')
                {
                    try
                    {
                        textBox5.Text = string.Concat(objNum1.number_BelongsTwo(int.Parse(textBox2.Text)));
                    }
                    catch
                    {
                        Interaction.MsgBox("Primero ingrese los parametros...");
                    }
                }   
            }
            catch
            {
                Interaction.MsgBox("Se cancelo la operacion...");
            }
        }

        private void verificarSiPerteneceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if((objNum2 == null) || (objNum3 == null))
                {
                    objNum1.number_Intersection(objNum2, ref objNum3);
                    textBox6.Text = string.Concat("El numero es: " + objNum3.get_Date());
                }               
            }
            catch
            {
                Interaction.MsgBox("ingrese los datos...");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializamos los objetos
            objNum1 = new claseEnteros();
            objNum2 = new claseEnteros();
            objNum3 = new claseEnteros();
        }
    }
}
