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
public class Subject {

    private final Observer[] observers = new Observer[9];
    private int totalObs = 0;
    private int state;

    public void attach(Observer o) {
        observers[totalObs++] = o;
    }

    public int getState() {
        return state;
    }

    public void setState(int in) {
        state = in;
        for (int i = 0; i < totalObs; i++) {
            observers[i].update();
        }
    }
}
