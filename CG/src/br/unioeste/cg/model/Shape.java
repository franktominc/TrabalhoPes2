/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.unioeste.cg.model;

import java.awt.Color;
import java.awt.Graphics;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public interface Shape {
    public void draw(Graphics g);
    public Color getColor();
}
