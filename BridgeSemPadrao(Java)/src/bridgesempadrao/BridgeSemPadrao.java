/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bridgesempadrao;

/**
 *
 * @author Cristhian
 */
public class BridgeSemPadrao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        MSWindrawn A = new MSWindrawn();
        UnityDrawn B = new UnityDrawn();
        
        A.drawnline();
        A.drawntextbox();
        B.drawnline();
        B.drawntextbox();
        
        
    }
    
}
