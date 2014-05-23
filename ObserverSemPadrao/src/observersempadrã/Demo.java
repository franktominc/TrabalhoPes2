/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package observersempadrã;

import java.util.Scanner;

/**
 *
 * @author Lek
 */
public class Demo {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        Subject sub = new Subject();
        Scanner scan = new Scanner(System.in);
        while (true) {
            System.out.print("\nEntre com um numero: ");
            Integer num = scan.nextInt();
            sub.toHex(num);
            sub.toOct(num);
            sub.toBin(num);
        }
    }
    
}
