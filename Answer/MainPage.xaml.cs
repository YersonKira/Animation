using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace Answer
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Pregunta> preguntas = new List<Pregunta>() { 
                new Pregunta(){ Enunciado = "Pregunta 1", Opciones = new List<string>() { "OP 1", "OP 2", "OP 3" }, Respuesta = 0}, 
                new Pregunta(){ Enunciado = "Pregunta 2", Opciones = new List<string>() { "OP 1", "OP 3" }, Respuesta = 1}, 
                new Pregunta(){ Enunciado = "Pregunta 3", Opciones = new List<string>() { "OP 2", "OP 3" }, Respuesta = 0}, 
                new Pregunta(){ Enunciado = "Pregunta 4", Opciones = new List<string>() { "OP 1", "OP 2" }, Respuesta = 1}, 
                new Pregunta(){ Enunciado = "Pregunta 5", Opciones = new List<string>() { "OP 1", "OP 3" }, Respuesta = 1}
            };
            this.Frame.Navigate(typeof(SecondPage), new Datos() { Datas = preguntas, Index = 0 });
        }   
    }
    public class Pregunta
    {
        public string Enunciado { get; set; }
        public List<string> Opciones { get; set; }
        public int Respuesta { get; set; }
    }
    public class Datos
    {
        public int Index { get; set; }
        public List<Pregunta> Datas { get; set; }
    }
}
