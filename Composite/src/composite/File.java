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
public class File implements AbstractFile {

    private String m_name;

    public File(String name) {
        m_name = name;
    }

    @Override
    public void ls() {
        System.out.println(Composite.g_indent + m_name);
    }

}
