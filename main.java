/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package progra.pkg2.parcial.pkg1;

import java.util.Scanner;

/**
 *
 * @author Alexis
 */
public class main {
    public static void main(String[] args) {
        Scanner t = new Scanner(System.in);
        String name = "";
        
        ClsComplemento complemento = new ClsComplemento();
        ClsDatos datos = new ClsDatos();
        

        System.out.println("Descipcion ");
        System.out.println("");
        
        datos.NombreProducto = "Bolas de \ncemento   ";
        datos.NumeroUnidades = 50;
        datos.PrecioUnitario = 60;
        datos.Kilogramos = 50;
        complemento.AgregaVendedores(datos);
        
        
        
         datos.NombreProducto = "Bolsas de Cal ";
        datos.NumeroUnidades = 150;
        datos.PrecioUnitario = 40;
        ClsDatos.Kilogramos = 20;
        complemento.AgregaVendedores(datos);
        
         datos.NombreProducto = "tubos PC";
        datos.NumeroUnidades = 200;
        datos.PrecioUnitario = 55;
        ClsDatos.Kilogramos = 10;
        complemento.AgregaVendedores(datos);
        
         datos.NombreProducto = "Quintales de \n hierro     ";
        datos.NumeroUnidades = 50;
        datos.PrecioUnitario = 350;
        ClsDatos.Kilogramos = 50;
        complemento.AgregaVendedores(datos);
        
        
               

        complemento.operaciones(datos);
        complemento.imprimirDecorado();

    
        
        
        
        
        
    }
}
