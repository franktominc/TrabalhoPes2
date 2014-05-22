package br.unioeste.cg.controller;

import br.unioeste.cg.view.AreaDesenho;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class MouseLocationListener implements MouseMotionListener {

    private AreaDesenho panel;

    public MouseLocationListener(AreaDesenho panel) {
        this.panel = panel;

    }

    @Override
    public void mouseDragged(MouseEvent e) {
        panel.getView().setTextLabel("Mouse position: " + e.getX() + ", " + e.getY());
        if (panel.isDrawing()) {
            panel.setP2(e.getPoint());
            panel.repaint();
        }
    }

    @Override
    public void mouseMoved(MouseEvent e) {
        mouseDragged(e);
    }

}
