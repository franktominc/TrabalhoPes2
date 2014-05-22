/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package observersempadrã;

/**
 *
 * @author Lek
 */
public class Subject {
    public void toHex(Integer i){
       System.out.print(" " + Integer.toHexString(i)); 
    }
    public void toOct(Integer i){
       System.out.print(" " + Integer.toOctalString(i)); 
    }
    
    public void toBin(Integer i){
       System.out.print(" " + Integer.toBinaryString(i)); 
    }
    
}
