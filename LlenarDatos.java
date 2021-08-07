/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datos;

import java.util.ArrayList;
import java.util.List;
import objeto.Datos;

/**
 *
 * @author Alexis
 */
public class LlenarDatos {

    private final int MAX_FILAS = 6;
    private final int MAX_COLUMNAS = 9;

    private String[][] factura = new String[MAX_FILAS][MAX_COLUMNAS];

    private final int UNIDADES = 0;
    private final int PRODUCTO = 1;
    private final int DESCRIPCION = 2;
    private final int PRECIO = 3;
    private final int GASTO_VALOR = 4;
    private final int GASTO_PESO = 5;
    private final int COSTO_UNIDAD = 6;
    private final int COSTO_TOTAL = 7;
    private final int PESO = 8;

    private final double SEGURO_LOCAL = 4000.0;
    private final double FLETE = 100.0;
    private final double IMPUESTOS = 2800.0;
    private final double ACARREO = 150.0;
    private final double COMISIONES = 350.0;

    private double valorTotal = 0;
    private double gastosValor = 0;
    private double gastosPeso = 0;
    private double coeficienteGasto = 0;
    private double coeficienteGastoPeso = 0;
    private double gastoPesoProducto = 0;
    private double pesoTotal = 0;

    //COMO SE AGREGA UN ENCABEZADO ENTONCES LA FILA AUMENTA EN 1
    private int filaActual = 1;

    public void llenadoDatos() {

        // ESTO PUEDE HACERSE MÁS DINÁMICO CON OTRO ARREGLO U OBJETO
        factura[0][UNIDADES] = "Unidades";
        factura[0][PRODUCTO] = "Producto";
        factura[0][DESCRIPCION] = "Descripción";
        factura[0][PRECIO] = "Precio";
        factura[0][GASTO_VALOR] = "Gasto Valor";
        factura[0][GASTO_PESO] = "Gasto Peso";
        factura[0][COSTO_UNIDAD] = "Costo Unidad";
        factura[0][COSTO_TOTAL] = "Costo Total";
        factura[0][PESO] = "Peso";

        Datos dato1 = new Datos(3, "Legion Y545 2020", "Laptop Gaming 6GB RTX", 11700.75, 0, 0, 0, 0, 2.3);
        agregarDatoMatriz(dato1);
        Datos dato2 = new Datos(1, "Mouse Óptico Gladius", "Mouse rgb para gamer", 550.0, 0, 0, 0, 0, 0.5);
        agregarDatoMatriz(dato2);
        Datos dato3 = new Datos(1, "Teclado Red Dragon", "Teclado mecánico rgb", 525.50, 0, 0, 0, 0, 1.6);
        agregarDatoMatriz(dato3);
        Datos dato4 = new Datos(1, "Mochila Red Dragon", "Mochila protectora para laptop", 450.20, 0, 0, 0, 0, 1.0);
        agregarDatoMatriz(dato4);
        Datos dato5 = new Datos(4, "USB Kingston 128", "Pen drive de 128 GB", 200.0, 0, 0, 0, 0, 0.3);
        agregarDatoMatriz(dato5);

    }

    public void agregarDatoMatriz(Datos dato) {
        factura[filaActual][UNIDADES] = (String.valueOf(dato.getUnidades()));
        factura[filaActual][PRODUCTO] = dato.getProducto();
        factura[filaActual][DESCRIPCION] = dato.getDesc();
        factura[filaActual][PRECIO] = (String.valueOf(dato.getPrecio()));
        factura[filaActual][GASTO_VALOR] = (String.valueOf(dato.getGastoValor()));
        factura[filaActual][GASTO_PESO] = (String.valueOf(dato.getGastoPeso()));
        factura[filaActual][COSTO_UNIDAD] = (String.valueOf(dato.getCostoUnidad()));
        factura[filaActual][COSTO_TOTAL] = (String.valueOf(dato.getCostoTotal()));
        factura[filaActual][PESO] = (String.valueOf(dato.getPeso()));

        filaActual = filaActual + 1;
    }

    public void mostrarDatos() {

        System.out.println("Priner paso: Multiplicar producto por unidad: ");

        for (int f = 0; f < factura.length; f++) {

            for (int c = 0; c < MAX_COLUMNAS; c++) {

                if (f > 0 && c == COSTO_TOTAL) {
                    factura[f][c] = String.valueOf((Integer.parseInt(factura[f][UNIDADES]) * Double.parseDouble(factura[f][PRECIO])));
                    valorTotal = valorTotal + Double.parseDouble(factura[f][c]);
                }

                System.out.print(factura[f][c] + " |");
            }

            System.out.println("");
        }
        System.out.println("TOTAL FACTURA: Q" + valorTotal + "\n");

        System.out.println("Segundo paso: Calcular gastos de valor según lo siguiente: ");
        System.out.println("Seguro de local: Q" + SEGURO_LOCAL);
        System.out.println("Impuestos: Q" + IMPUESTOS);
        System.out.println("Comisiones: Q" + COMISIONES);

        gastosValor = SEGURO_LOCAL + IMPUESTOS + COMISIONES;

        System.out.println("Gastos al valor: Q" + gastosValor + "\n");

        System.out.println("Tercer paso - Establecer coeficiente: TotalGastos / TotalFactura = Q" + gastosValor + " / " + valorTotal);
        coeficienteGasto = gastosValor / valorTotal;
        System.out.println("Coeficiente del gasto al valor: " + coeficienteGasto + "\n");

        System.out.println("Cuarto paso: calcular gastos al valor por productos = Precio * coeficiente");

        for (int f = 0; f < factura.length; f++) {

            if (f > 0) {

                double gastoValorProducto = Double.parseDouble(factura[f][PRECIO]) * coeficienteGasto;
                System.out.println(factura[f][PRECIO] + " * " + coeficienteGasto + " = " + gastoValorProducto);
            }

        }
        
        System.out.println("");
        
        
        System.out.println("Quinto paso: calcular peso total de mercadería = Peso * Unidad");

        for (int f = 0; f < factura.length; f++) {

            if (f > 0) {

                double pesoFila = (Double.parseDouble(factura[f][PESO]) * Double.parseDouble(factura[f][UNIDADES]));
                pesoTotal = pesoTotal + pesoFila;
                System.out.println(factura[f][PESO] + "kg * " + factura[f][UNIDADES] + " = " + pesoFila);
            }

        }
        
        System.out.println("Peso Total = " + pesoTotal + " kilogramos\n");

        
        System.out.println("Sexto paso paso: Calcular gastos de peso de productos: ");
        System.out.println("Flete: Q" + FLETE);
        System.out.println("Acarreo: Q" + ACARREO);
        
        gastoPesoProducto = FLETE + ACARREO;
        System.out.println("Gastos al peso: Q" + gastoPesoProducto + "\n");
        
        System.out.println("Séptimo paso - Establecer coeficiente del gasto de peso: TotalGastosPeso / TotalPeso = Q" + gastoPesoProducto + " / " + pesoTotal);
        coeficienteGastoPeso = gastoPesoProducto / pesoTotal;
        System.out.println("Coeficiente del gasto al peso: " + coeficienteGastoPeso + "\n");
        
        
        System.out.println("Octavo paso: calcular gastos al peso por productos = Peso de unidad * coeficiente de peso");

        for (int f = 0; f < factura.length; f++) {

            if (f > 0) {

                double gastoPesoP = Double.parseDouble(factura[f][PESO]) * coeficienteGastoPeso;
                System.out.println(factura[f][PESO] + " * " + coeficienteGastoPeso + " = " + gastoPesoP);
            }

        }
        
        System.out.println("");
    }

}
