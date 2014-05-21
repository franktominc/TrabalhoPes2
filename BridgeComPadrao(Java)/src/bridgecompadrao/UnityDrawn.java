/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bridgecompadrao;

/**
 *
 * @author Cristhian
 */
public class UnityDrawn implements Bridge {
    public UnityDrawn(){
        
    }
    public void drawnline(){
        System.out.println("Desenhando uma linha no estilo Unity");
    }
    public void drawntextbox (){
        System.out.println("Desenhando uma caixa de texto no estilo Unity");
    }
}
