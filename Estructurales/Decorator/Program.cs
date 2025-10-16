// See https://aka.ms/new-console-template for more information
using Decorator;

VistaVehiculo vista = new VistaVehiculo();
//vista.visualiza();

ModeloDecorador modeloDecorador = new ModeloDecorador(vista);
modeloDecorador.visualiza();

MarcaDecorador marcaDecorador = new MarcaDecorador(modeloDecorador);
marcaDecorador.visualiza();