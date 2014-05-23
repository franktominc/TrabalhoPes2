/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package state;

/**
 *
 * @author Lek
 */
public class Low implements State {

    @Override
    public void pull(CeilingFanPullChain wrapper) {
        wrapper.setM_current_state(new Medium());
        System.out.println("   medium speed");
    }

}
