/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package composite;

import java.util.ArrayList;

/**
 *
 * @author Lek
 */
public class Directory implements AbstractFile {

    private String m_name;
    private ArrayList m_files = new ArrayList();

    public Directory(String name) {
        m_name = name;
    }

    public void add(Object obj) {
        m_files.add(obj);
    }

    @Override
    public void ls() {
        
        System.out.println(Composite.g_indent + m_name);
        Composite.g_indent.append("   ");
        for (int i = 0; i < m_files.size(); ++i) {
            // Leverage the "lowest common denominator"
            AbstractFile obj = (AbstractFile) m_files.get(i);
            obj.ls();
        }
        Composite.g_indent.setLength(Composite.g_indent.length() - 3);
    }

}
