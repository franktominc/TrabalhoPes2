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
public class Desenha {
    private Bridge bridge;
    public Desenha(Bridge bridge){
        this.bridge = bridge;
    }
    public void DesenhaLinhaNaTela(){
        bridge.drawnline();
    }
    public void DesenhaCaixaDeTextoNaTela(){
        bridge.drawntextbox();
    }
}
