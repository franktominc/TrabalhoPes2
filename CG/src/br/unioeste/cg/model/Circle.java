package br.unioeste.cg.model;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class Circle implements Shape {

    private Point middle;
    private int radius;
    private Color cor;

    public Circle(Point middle, int radius, Color cor) {
        this.middle = middle;
        this.radius = radius;
        this.cor = cor;
    }

    @Override
    public void draw(Graphics g) {
        int x = 0;
        int y = radius;
        int d = 1 - radius;
        circlePoints(x, y, g);
        while (y > x) {
            if (d < 0) {
                d += 2 * x + 3;
            } else {
                d += 2 * (x - y) + 5;
                y--;
            }
            x++;
            circlePoints(x, y, g);
        }
    }

    public void circlePoints(int x, int y, Graphics g) {
        if (radius != 0) {
            g.drawLine(middle.x + x, middle.y + y, middle.x + x, middle.y + y);
            g.drawLine(middle.x + x, middle.y - y, middle.x + x, middle.y - y);
            g.drawLine(middle.x - x, middle.y - y, middle.x - x, middle.y - y);
            g.drawLine(middle.x - x, middle.y + y, middle.x - x, middle.y + y);
            g.drawLine(middle.x - y, middle.y + x, middle.x - y, middle.y + x);
            g.drawLine(middle.x - y, middle.y - x, middle.x - y, middle.y - x);
            g.drawLine(middle.x + y, middle.y - x, middle.x + y, middle.y - x);
            g.drawLine(middle.x + y, middle.y + x, middle.x + y, middle.y + x);
        }
    }

    @Override
    public Color getColor() {
        return cor;
    }
    

}
