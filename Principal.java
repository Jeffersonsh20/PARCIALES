/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datos;

/**
 *
 * @author Alexis
 */
public class Principal {
    
    LlenarDatos llenar = new LlenarDatos();
    
    public void iniciar(){
        llenar.llenadoDatos();
        llenar.mostrarDatos();
    }
    
}
