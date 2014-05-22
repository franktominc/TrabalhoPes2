/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package composite;

/**
 *
 * @author Lek
 */
public class Composite {

    public static StringBuffer g_indent = new StringBuffer();

    public static void main(String[] args) {
        Directory one = new Directory("dir111"), two = new Directory("dir222"),
                thr = new Directory("dir333");
        File a = new File("a"), b = new File("b"), c = new File("c"), d = new File("d"), e = new File("e");
        one.add(a);
        one.add(two);
        one.add(b);
        two.add(c);
        two.add(d);
        two.add(thr);
        thr.add(e);
        one.ls();
    }

}
