
package br.unioeste.cg.model;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class Line implements Shape {

    private Point p1;
    private Point p2;
    private Color cor;

    public Line(Point p1, Point p2, Color cor) {
        this.p1 = p1;
        this.p2 = p2;
        this.cor = cor;
    }

    @Override
    public void draw(Graphics g) {
        //utilizando algoritmo de Bresenham
        int a, b, slope, incrE, incrNE, x, y;
        if (Math.abs(p2.y - p1.y) > Math.abs(p2.x - p1.x)) {
            if (p2.y < p1.y) {
                Point aux = p1;
                p1 = p2;
                p2 = aux;
            }
            b = p2.y - p1.y;
            a = p2.x - p1.x;

            if (a < 0) {
                slope = -1;
                a = -a;
            } else {
                slope = 1;
            }
            int V = 2 * a - b; //valor inicial de V
            incrE = 2 * a; //Mover para E
            incrNE = 2 * (a - b); //Mover para NE

            x = p1.x;
            y = p1.y;

            g.drawLine(x, y, x, y);
            while (y < p2.y) {
                if (V <= 0) {
                    V += incrE; //escolhe E 
                } else { //escolhe NE
                    V += incrNE;
                    x += slope;
                }
                ++y;
                g.drawLine(x, y, x, y);
            }
        } else {
            if (p2.x < p1.x) {
                Point aux = p1;
                p1 = p2;
                p2 = aux;
            }
            a = p2.y - p1.y;
            b = p2.x - p1.x;

            if (a < 0) {
                slope = -1;
                a = -a;
            } else {
                slope = 1;
            }
            int V = 2 * a - b; //valor inicial de V
            incrE = 2 * a; //Mover para E
            incrNE = 2 * (a - b); //Mover para NE

            x = p1.x;
            y = p1.y;

            g.drawLine(x, y, x, y);
            while (x < p2.x) {
                if (V <= 0) {
                    V += incrE; //escolhe E 
                } else { //escolhe NE
                    V += incrNE;
                    y += slope;
                }
                ++x;
                g.drawLine(x, y, x, y);
            }
        }

    }

    @Override
    public Color getColor() {
        return cor;
    }

 

}
