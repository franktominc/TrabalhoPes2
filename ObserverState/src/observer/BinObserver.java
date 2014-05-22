/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

/**
 *
 * @author Lek
 */
class BinObserver extends Observer {

    public BinObserver(Subject s) {
        subj = s;
        subj.attach(this);
    } // Observers register themselves 

    public void update() {
        System.out.print(" " + Integer.toBinaryString(subj.getState()));
    }
}
