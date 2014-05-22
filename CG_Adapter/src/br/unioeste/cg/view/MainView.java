package br.unioeste.cg.view;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JSeparator;
import javax.swing.JToggleButton;
import javax.swing.SwingConstants;

/**
 *
 * @author Alexandre Luiz de Borba Silva
 */
public class MainView extends JFrame {

    private JLabel textLabel = new JLabel("", SwingConstants.LEFT);
    private AreaDesenho areaDesenho;
    private JToggleButton bntLine;
    private JToggleButton bntCircumference;
    private JToggleButton bntEllipse;
    private JButton bntColor;
    private JColorChooser colorPallete;

    public MainView(String title) {
        super(title);
        this.setLayout(null);
        setSize(635, 800);
        areaDesenho = new AreaDesenho(this);
        areaDesenho.setBounds(10, 50, 600, 600);
        add(areaDesenho);

        //        
        JMenuBar menuBar = new JMenuBar();
        JMenu menu = new JMenu("Arquivo");
        JMenuItem menuItem = new JMenuItem("Novo");
        menuItem.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                areaDesenho.initShapes();
                repaint();
            }
        });
        menu.add(menuItem);
        menuBar.add(menu);
        setJMenuBar(menuBar);
        //        
        bntLine = new JToggleButton(new ImageIcon("line.png"));
        bntLine.setSelectedIcon(new ImageIcon("linePressed.png"));
        bntLine.setBounds(10, 10, 30, 30);
        bntLine.setToolTipText("Line");
        bntLine.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                areaDesenho.setShape(0);
                areaDesenho.initPoints();
                bntCircumference.setSelected(false);
                bntEllipse.setSelected(false);
            }
        });
        add(bntLine);
        //
        bntCircumference = new JToggleButton(new ImageIcon("circuference.png"));
        bntCircumference.setSelectedIcon(new ImageIcon("circuferencePressed.png"));
        bntCircumference.setBounds(50, 10, 30, 30);
        bntCircumference.setToolTipText("Circumference");
        bntCircumference.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                areaDesenho.setShape(1);
                areaDesenho.initPoints();
                bntLine.setSelected(false);
                bntEllipse.setSelected(false);
            }
        });
        add(bntCircumference);
        //
        bntEllipse = new JToggleButton(new ImageIcon("ellipse.png"));
        bntEllipse.setSelectedIcon(new ImageIcon("ellipsePressed.png"));
        bntEllipse.setBounds(90, 10, 30, 30);
        bntEllipse.setToolTipText("Ellipse");
        bntEllipse.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                areaDesenho.setShape(2);
                areaDesenho.initPoints();
                bntLine.setSelected(false);
                bntCircumference.setSelected(false);
            }
        });
        add(bntEllipse);
        //



        //        
        textLabel.setBounds(10, 620, 300, 100);
        add(textLabel);
        //
        JSeparator separator = new JSeparator(SwingConstants.VERTICAL);
        separator.setBounds(125, 10, 1, 30);
        add(separator);
        //
        bntColor = new JButton();
        bntColor.setBackground(Color.BLACK);
        bntColor.setBounds(130, 10, 30, 30);
        colorPallete = new JColorChooser();
        bntColor.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                bntColor.setBackground(colorPallete.showDialog(null, "Selecione uma cor", bntColor.getBackground()));
                areaDesenho.setCor(bntColor.getBackground());
            }
        });
        add(bntColor);
        //
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public static void main(String[] args) {
        MainView view = new MainView("Alexandre Luiz de Borba Silva - Trabalho Extra CG - 2014");
        view.setVisible(true);

    }

    public void setTextLabel(String text) {
        this.textLabel.setText(text);
    }
}
