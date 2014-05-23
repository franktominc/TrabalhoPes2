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
public class CeilingFanPullChain {

    private State m_current_state;

    public CeilingFanPullChain() {
        m_current_state = new Off();
    }

    public State getM_current_state() {
        return m_current_state;
    }

    public void setM_current_state(State m_current_state) {
        this.m_current_state = m_current_state;
    }

    public void pull() {
        m_current_state.pull(this);
    }
}
