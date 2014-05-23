/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observer;

import java.util.Scanner;



/**
 *
 * @author Lek
 */
public class ObserverDemo {

    public static void main(String[] args) {
        Subject sub = new Subject();
        // Client configures the number and type of Observers
        new HexObserver(sub);
        new OctObserver(sub);
        new BinObserver(sub);
        Scanner scan = new Scanner(System.in);
        while (true) {
            System.out.print("\nEntre com um numero: ");
            sub.setState(scan.nextInt());
        }
    }
}
