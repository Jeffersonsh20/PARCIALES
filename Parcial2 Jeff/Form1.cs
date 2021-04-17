using Parcial2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;

        private enum columnas
        {
            Correlativo = 0,
            Nombre = 1,
            Parcial1 = 2,
            Parcial2 = 3,
            Parcial3 = 4,

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ja = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Porfavor, Seleccionar tu Archivo plano";
            ofd.InitialDirectory = @"C:\Users\Jefferson Molina\OneDrive\Escritorio\Datosss\";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ja.leertodoArch(archivo);
                ArregloNotas = ja.LeerArch(archivo);
                textBoxResultado.Text = resultado;
            }
        }



        private int Fncpromedios(string[,] matriz, int columnas)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador / matriz.GetLength(0);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;
        }



        private void buttonPromedioparciall_Click(object sender, EventArgs e)
        {
            
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 5];
            int Numerolinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[Numerolinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[Numerolinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[Numerolinea, enumColumnas.parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[Numerolinea, enumColumnas.parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[Numerolinea, enumColumnas.parcial3] = datosUnitarios[4];
                Numerolinea++;
                listBoxResultado.Items.Add($"{datosUnitarios[enumColumnas.Nombre]} nota : {datosUnitarios[enumColumnas.parcial2]})");
            }
            int promedio = Fncpromedios(ArregloDosDimensiones, 2);
            MessageBox.Show($"El Promedio Del parcial 2");
            promedio = 0;
        }

        private void buttonPromedioporSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Interface promedio = new Interface();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promedioSS1 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial1, "A");
            int promedioYY2 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial2, "A");
            int promedioSAP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial3, "A");
            int promedioSBP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial1, "B");
            int promedioSBP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial2, "B");
            int promedioSBP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial3, "B");
            int promedioSCP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial1, "C");
            int promedioSCP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial2, "C");
            int promedioSCP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, enumColumnas.parcial3, "C");

            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 1: {promedioSS1}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 2: {promedioYY2}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 3: {promedioSAP3}");

            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 1: {promedioSBP1}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 2: {promedioSBP2}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 3: {promedioSBP3}");

            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 1: {promedioSCP1}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 2: {promedioSCP2}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 3: {promedioSCP3}");
        }

        private void limpiarCaja()
        {
            listBoxResultado.Items.Clear();
        }

        private void buttonPromedioGeneralSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Interface promedio = new Interface();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumerLin = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumerLin, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumerLin, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumerLin, enumColumnas.Seccion] = DatosUnitarios[5];
                NumerLin++;
            }

            int promedioGeneraldelaA = promedio.promedio_general_seccion(ArregloDosDimensiones, "A");
            int promedioGeneraldeB = promedio.promedio_general_seccion(ArregloDosDimensiones, "B");
            int promedioGeneraldelaC = promedio.promedio_general_seccion(ArregloDosDimensiones, "C");

            listBoxResultado.Items.Add($"Promedio General Sección A: {promedioGeneraldelaA}");
            listBoxResultado.Items.Add($"Promedio General Sección B: {promedioGeneraldeB}");
            listBoxResultado.Items.Add($"Promedio General Sección C: {promedioGeneraldelaC}");
        }

        private void buttonClasificaciondeAlunmos_Click(object sender, EventArgs e)
        {

            limpiarCaja();
            Interface promedio = new Interface();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumerLin = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumerLin, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumerLin, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumerLin, enumColumnas.Seccion] = DatosUnitarios[5];
                NumerLin++;
            }

            string[,] alumnoClasificado = promedio.Clasificar_Alumnos(ArregloDosDimensiones, "B");
            string nomb = alumnoClasificado[0, 0];
            string not = alumnoClasificado[0, 1];

            listBoxResultado.Items.Add($" --- ALUMNOS CON MEJORES NOTAS ---");
            listBoxResultado.Items.Add($"SECCIÓN B:");
            listBoxResultado.Items.Add($"Nombre: {nomb}");
            listBoxResultado.Items.Add($"Sumatoria de los parciales: {not}");
        }

        private void buttonNotaGeneralMayor_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Interface promedio = new Interface();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumerLin = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumerLin, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumerLin, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumerLin, enumColumnas.Seccion] = DatosUnitarios[5];
                NumerLin++;
            }

            string mayr = promedio.nombre_nota_mayor(ArregloDosDimensiones);

            listBoxResultado.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR ---");
            listBoxResultado.Items.Add($"Nombre: {mayr}");
        }

        private void buttonNOTAMAYOR_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Interface promedio = new Interface();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumerLin = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumerLin, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumerLin, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumerLin, enumColumnas.parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumerLin, enumColumnas.Seccion] = DatosUnitarios[5];
                NumerLin++;
            }

            string mayr = promedio.nombre_nota_mayor(ArregloDosDimensiones, "C");

            listBoxResultado.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR SECCIÓN C ---");
            listBoxResultado.Items.Add($"Nombre: {mayr}");
        }
    }
}
