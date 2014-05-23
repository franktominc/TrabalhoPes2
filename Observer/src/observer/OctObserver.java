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
public class OctObserver extends Observer{

    public OctObserver(Subject s) {
        subj = s;
        subj.attach(this);
    }

    public void update() {
        System.out.print(" " + Integer.toOctalString(subj.getState()));
    }

}
