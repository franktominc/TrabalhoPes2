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
public class BridgeComPadrao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Desenha desenhaEmWindows = new Desenha(new MSWindrawn());
        Desenha desenhaEmLinux = new Desenha(new UnityDrawn());
        
        desenhaEmWindows.DesenhaLinhaNaTela();
        desenhaEmLinux.DesenhaLinhaNaTela();
        desenhaEmWindows.DesenhaCaixaDeTextoNaTela();
        desenhaEmLinux.DesenhaCaixaDeTextoNaTela();
    }
    
}
