/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package statesempadrao;

/**
 *
 * @author Lek
 */
public class CeilingFanPullChain {

    private int m_current_state;

    public CeilingFanPullChain() {
        m_current_state = 0;
    }

    public void pull() {
        if (m_current_state == 0) {
            m_current_state = 1;
            System.out.println("   low speed");
        } else if (m_current_state == 1) {
            m_current_state = 2;
            System.out.println("   medium speed");
        } else if (m_current_state == 2) {
            m_current_state = 3;
            System.out.println("   high speed");
        } else {
            m_current_state = 0;
            System.out.println("   turning off");
        }
    }
}
