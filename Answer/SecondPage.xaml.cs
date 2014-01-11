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
    public sealed partial class SecondPage : Page
    {
        public Datos datas { get; set; }
        public SecondPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Pregunta pregunta = new Pregunta()
            //{
            //    Enunciado = "Enunciado",
            //    Opciones = new List<string>(){ 
            //        "OP 1",
            //        "OP 2"
            //    },
            //    Respuesta = 0
            //};
            datas = e.Parameter  as Datos;
            this.DataContext = datas.Datas[datas.Index];
            base.OnNavigatedTo(e);
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((DataContext as Pregunta).Respuesta == ops.SelectedIndex)
            {
                var message = new MessageDialog("Opcion correcta");
                await message.ShowAsync();
            }
            else
            {
                var message = new MessageDialog("Opcion incorrecta");
                await message.ShowAsync();
            }
            if (datas.Index + 1 == datas.Datas.Count)
            {
                var message = new MessageDialog("Final");
                await message.ShowAsync();
            }
            else
            {
                datas.Index++;
                this.Frame.Navigate(typeof(SecondPage), datas);
            }
        }
    }
}
