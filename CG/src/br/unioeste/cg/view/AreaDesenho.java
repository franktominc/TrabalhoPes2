/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.unioeste.cg.view;

import br.unioeste.cg.controller.MouseHandler;
import br.unioeste.cg.controller.MouseLocationListener;
import br.unioeste.cg.model.Circle;
import br.unioeste.cg.model.Ellipse;
import br.unioeste.cg.model.Line;
import br.unioeste.cg.model.Shape;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;
import java.util.ArrayList;
import javax.swing.JPanel;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class AreaDesenho extends JPanel {

    private MainView view;
    private ArrayList<Shape> shapes;
    private Point p1;
    private Point p2;
    private int shape = -1;
    private Color color;
    private boolean drawing;

    public AreaDesenho(MainView view) {
        this.view = view;
        setBackground(Color.white);
        addMouseMotionListener(new MouseLocationListener(this));
        addMouseListener(new MouseHandler(this));
        initShapes();
        color = Color.BLACK;
    }

    public void initShapes() {
        shapes = new ArrayList<>();
        initPoints();
    }

    public void initPoints() {
        p1 = null;
        p2 = null;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        if (isDrawing()) {
            g.setColor(color);
            switch (shape) {
                case 0:
                    (new Line(p1, p2, color)).draw(g);
                    break;
                case 1:
                    (new Circle(p1, (int) Point.distance(p1.x, p1.y, p2.x, p2.y), color)).draw(g);
                    break;
                case 2:
                    new Ellipse(p1, (int) Point.distance(p1.x, p1.y, p2.x, p1.y), (int) Point.distance(p1.x, p1.y, p1.x, p2.y), color).draw(g);
                    break;
            }
        } else {
            if (p1 != null && p2 != null) {
                switch (shape) {
                    case 0:
                        shapes.add(new Line(p1, p2, color));
                        break;
                    case 1:
                        shapes.add(new Circle(p1, (int) Point.distance(p1.x, p1.y, p2.x, p2.y), color));
                        break;
                    case 2:
                        shapes.add(new Ellipse(p1, (int) Point.distance(p1.x, p1.y, p2.x, p1.y), (int) Point.distance(p1.x, p1.y, p1.x, p2.y), color));
                        break;
                }
            }
            p1 = null;
            p2 = null;
        }
        for (Shape s : shapes) {
            g.setColor(s.getColor());
            s.draw(g);
        }

    }

    public Point getP1() {
        return p1;
    }

    public void setP1(Point p1) {
        this.p1 = p1;
    }

    public Point getP2() {
        return p2;
    }

    public void setP2(Point p2) {
        this.p2 = p2;
    }

    public int getShape() {
        return shape;
    }

    public void setShape(int shape) {
        this.shape = shape;
    }

    public Color getCor() {
        return color;
    }

    public void setCor(Color cor) {
        this.color = cor;
    }

    public MainView getView() {
        return view;
    }

    public void setView(MainView view) {
        this.view = view;
    }

    public boolean isDrawing() {
        return drawing;
    }

    public void setDrawing(boolean drawing) {
        this.drawing = drawing;
    }

}
