package br.unioeste.cg.controller;

import br.unioeste.cg.view.AreaDesenho;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class MouseHandler extends MouseAdapter {

    private AreaDesenho panel;

    public MouseHandler(AreaDesenho panel) {
        this.panel = panel;
    }

    @Override
    public void mousePressed(MouseEvent e) {
        panel.setDrawing(true);
        panel.setP1(e.getPoint());
        panel.setP2(e.getPoint());
        panel.repaint();
    }

    @Override
    public void mouseReleased(MouseEvent e) {
        panel.setDrawing(false);
        panel.setP2(e.getPoint());
        panel.repaint();
        this.mouseClicked(e);
    }



}
