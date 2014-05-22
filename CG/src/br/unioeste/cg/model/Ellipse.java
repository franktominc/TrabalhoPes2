
package br.unioeste.cg.model;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class Ellipse implements Shape {

    private Point middle;
    private int a; //eixo maior
    private int b; //eixo menor
    private Color cor;

    public Ellipse(Point middle, int a, int b, Color cor) {
        this.middle = middle;
        this.a = a;
        this.b = b;
        this.cor = cor;
    }

   

    @Override
    public void draw(Graphics g) {
        int a2 = a * a;
        int b2 = b * b;
        int twoa2 = 2 * a2;
        int twob2 = 2 * b2;
        int x = 0;
        int y = b;
        int px = 0;
        int py = twoa2 * y;
        int p;
        ellipsePoints(x, y, g);
        p = (int) (b2 - (a2 * b) + (0.25 * a2) + 0.5);
        while (px < py) {
            x++;
            px += twob2;
            if (p < 0) {
                p += b2 + px;
            } else {
                y--;
                py -= twoa2;
                p += b2 + px - py;
            }
            ellipsePoints(x, y, g);
        }
        p = (int) (b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2 + 0.5);
        while (y > 0) {
            y--;
            py -= twoa2;
            if (p > 0) {
                p += a2 - py;
            } else {
                x++;
                px += twob2;
                p += a2 - py + px;
            }
            ellipsePoints(x, y, g);
        }
    }

    public void ellipsePoints(int x, int y, Graphics g) {
        if (a != 0 && b != 0) { //rever isso aqui
            g.drawLine(middle.x + x, middle.y + y, middle.x + x, middle.y + y);
            g.drawLine(middle.x + x, middle.y - y, middle.x + x, middle.y - y);
            g.drawLine(middle.x - x, middle.y - y, middle.x - x, middle.y - y);
            g.drawLine(middle.x - x, middle.y + y, middle.x - x, middle.y + y);

        }
    }

    @Override
    public Color getColor() {
        return cor;
    }
}
