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

        float _numeroGrande;
        float _sumaDosLados;
        float _Area;
        float _Base;
        float _Lado1;
        float _Lado2;
        float _Altura;

        private void Area(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Lado_1.Text) && !string.IsNullOrEmpty(Lado_2.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                _Base = float.Parse(Base.Text);
                _Lado1 = float.Parse(Lado_1.Text);
                _Lado2 = float.Parse(Lado_2.Text);
                _Altura = float.Parse(Altura.Text);
                ConfirMarLadoGrande(_Base, _Lado1, _Lado2);
                if (_numeroGrande < _sumaDosLados)
                {
                    TipoTriangulo(_sumaDosLados, _numeroGrande);
                    CalcularArea(_Base, _Altura);
                    MostrarTriangulo(Tipo.Text);
                }
                else
                    DisplayAlert("Datos Incorrectos", "No es un triangulo", "Cerrar");

            }
            else

                DisplayAlert("Datos Incorrectos", "ingrese todos los datos", "Cerrar");

        }

        public void CalcularArea(float _Base, float _Altura)
        {
            _Area = (_Base * _Altura) / 2;
            AreaTriangulo.Text = _Area.ToString();
        }


        public void ConfirMarLadoGrande(float _Base, float _Lado1, float _Lado2)
        {

            if (_Base > _Lado1 && _Base > _Lado2)
            {
                _numeroGrande = _Base;
                _sumaDosLados = _Lado2 + _Lado1;


            }
            else if (_Lado1 > _Lado2 && _Lado1 > _Base)
            {
                _numeroGrande = _Lado1;
                _sumaDosLados = _Base + _Lado2;
            }
            else
            {
                _numeroGrande = _Lado2;
                _sumaDosLados = _Base + _Lado1;
            }
        }
        public void TipoTriangulo(float _sumaDosLados, float _numeroGrande)
        {

            if (_Base != _Lado1 && _Base != _Lado2 && _Lado2 != _Lado1)
                Tipo.Text = "Escaleno";//si lo muestra
            else if (_Base == _Lado1 && _Base == _Lado2 && _Lado2 == _Lado1)
                Tipo.Text = "Equilatero";//si lo muestra

            else //if (_Base == _Lado1 && _Base == _Lado2 && _Lado2 != _Lado1)
                Tipo.Text = "Isoseles";

        }

        public void MostrarTriangulo(string _Tipo)
        {
            if (_Tipo == "Escaleno")
            {
                imgEquilatero.IsVisible = false;
                imgEscaleno.IsVisible = true;
                imgisosceles.IsVisible = false;
            }

            else if (_Tipo == "Equilatero")
            {
                imgEquilatero.IsVisible = true;
                imgEscaleno.IsVisible = false;
                imgisosceles.IsVisible = false;
            }
            else if (_Tipo == "Isoseles")
            {
                imgEquilatero.IsVisible = false;
                imgEscaleno.IsVisible = false;
                imgisosceles.IsVisible = true;

            }


        }
    }

}
