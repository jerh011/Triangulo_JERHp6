using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_JERH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Area(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Lado_1.Text) && !string.IsNullOrEmpty(Lado_2.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                float _Area;
                float _Base = float.Parse(Base.Text);
                float _Lado1 = float.Parse(Lado_1.Text);
                float _Lado2 = float.Parse(Lado_2.Text);
                float _Altura = float.Parse(Altura.Text);
               
               
                float _numeroGrande;
                float _sumaDosLados;

                if (_Base > _Lado1 && _Base > _Lado2) {
                    _numeroGrande = _Base;
                    _sumaDosLados= _Lado2 - _Lado1;


                }
                else if (_Lado1 > _Lado2 && _Lado1 > _Base) { 
                     _numeroGrande = _Lado1;
                    _sumaDosLados = _Base + _Lado2; 
                }
                   else { 
                    _numeroGrande = _Lado2;
                    _sumaDosLados = _Base + _Lado1;
                }

                if (_numeroGrande < _sumaDosLados)
                {
                    _Area = (_Base * _Altura) / 2;
                    AreaTriangulo.Text = _Area.ToString();
                    if (_Base != _Lado1 && _Base != _Lado2 && _Lado2 != _Lado1)
                    {
                        Tipo.Text = "Escaleno";
                        imgEquilatero.IsVisible= true;
                    }
                    else if (_Base == _Lado1 && _Base == _Lado2 && _Lado2 == _Lado1)
                    {
                        Tipo.Text = "Equilatero";
                    }
                    else if (_Base == _Lado1 && _Base == _Lado2 && _Lado2 != _Lado1) { 
                    Tipo.Text = "Isoseles";
                    }
                }
                 else
                    DisplayAlert("Datos Incorrectos", "No es un triangulo", "Cerrar");
            }
            else
             
            DisplayAlert("Datos Incorrectos", "ingrese todos los datos", "Cerrar");

        }
    }
}


